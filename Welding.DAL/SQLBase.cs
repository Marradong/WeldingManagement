using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Welding.DAL
{
    public class QAWORX
    {

        #region QAJobNoLookup

        private List<PersonFields> People = new List<PersonFields>();

        private IPAddress MsSql_SERVER = System.Net.IPAddress.Parse("192.168.100.16");
        string QAWORX_ipAddress = @"cce-cv-svr11";// cce-svr02.camcoeng.com.au";// "cce -cv-svr06"; // "192.168.100.7";


        //bool QAWorxOnline = false;
        // Declare variables for the Connection, Adapter & DataSet
        SQLBaseConnection conn = new SQLBaseConnection();
        SQLBaseDataAdapter adaptor = new SQLBaseDataAdapter();
        DataSet ds = new DataSet();

        // Declare variable for Tut4
        SQLBaseDataAdapter myAdaptor = new SQLBaseDataAdapter();
        DataSet dstemp = new DataSet();
        DataSet myDataSet = new DataSet();

        SQLBaseConnection Open_SQLBase()
        {
            SQLBaseConnection SqlBase_Connection = new SQLBaseConnection();


            string SqlBase_ConnectionString = "Data Source =" + QAWORX_ipAddress + "; User = pressure; Password = pressure; InitialCatalog = camco;";
            SqlBase_Connection.ConnectionString = SqlBase_ConnectionString;
            try
            {
                SqlBase_Connection.Open();
            }
            catch
            {
                //No Network
                SqlBase_Connection = null;
            }

            return SqlBase_Connection;
        }

        public bool QAWORXServerAvailable()
        {

            try
            {
                TcpClient TcpClient = new TcpClient();

                var client = new TcpClient();


                if (!client.ConnectAsync(MsSql_SERVER, 1433).Wait(100))  //TODO change to QZWORX
                {
                    client.Close();
                    //Network up but Server Offline
                    return false;
                }
                client.Close();
                return true;
            }
            catch
            {
                //Send Message that Sql Offline
                //SocketException: A socket operation was attempted to an unreachable host
                return false;
            }

        }

        public List<PersonFields> Get_People_SQLBase()
        {

            if (!QAWORXServerAvailable())
                return null;

            SQLBaseConnection SqlBase_Connection = Open_SQLBase();

            if (SqlBase_Connection == null)
                return null;

            string People_QA_Query = "SELECT epb.oldempno, epb.name, epb.status, epb.location, epb.classification, epb.position, epb.department, epb.division, epb.department_order, epb.classification_order, " +
                                    "                epb.default_phone_id_office, epb.default_extension_id, epb.default_speed_dial_id, epb.default_email_id_office, " +
                                    "                @IF( @ISNA( epb.default_phone_id_office ), NULL, @IF( @IF( cdpo.is_private, 0, 1 ), cdpo.details, '<Private>' ) ) AS PhoneOffice, " +
                                    "                @IF( @ISNA( epb.default_extension_id ), NULL, @IF( @IF( cdpe.is_private, 0, 1 ), cdpe.details, '<Private>' ) ) AS CamcoExtension, " +
                                    "                @IF( @ISNA( epb.default_speed_dial_id ), NULL, @IF( @IF( cdps.is_private, 0, 1 ), cdps.details, '<Private>' ) ) AS CamcoSpeedDial, " +
                                    "                @IF( @ISNA( epb.default_email_id_office ), NULL, @IF( @IF( cdeo.is_private, 0, 1 ), cdeo.details, '<Private>' ) ) AS EmailOffice " +
                                    "FROM emp_phone_book epb, contact_details cdpo, contact_details cdpe, contact_details cdps, contact_details cdeo " +
                                    "WHERE cdpo.details_id = @NULLVALUE( epb.default_phone_id_office, 0 ) " +
                                    "                AND cdpe.details_id = @NULLVALUE( epb.default_extension_id, 0 ) " +
                                    "                AND cdps.details_id = @NULLVALUE( epb.default_speed_dial_id, 0 ) " +
                                    "                AND cdeo.details_id = @NULLVALUE( epb.default_email_id_office, 0 ) " +
                                    "ORDER BY 2";

            //A DataReader is forward-only read-only so you can't get the number of records before looping through them all.

            IDbCommand cmd = SqlBase_Connection.CreateCommand();
            IDbDataParameter param = cmd.CreateParameter();
            cmd.CommandText = People_QA_Query; //;txtPeopleQuery.Text;

            IDataReader reader = cmd.ExecuteReader();


            People.Clear();
            int Count = 0;

            while (reader.Read())
            {
                PersonFields person_SQLBase = new PersonFields();

                person_SQLBase.EmployeeNumber = SqlBaseField.Read<String>(reader, "epb.oldempno");
                person_SQLBase.Department = SqlBaseField.Read<String>(reader, "epb.department");

                string location = SqlBaseField.Read<String>(reader, "epb.location");
                string department_order = SqlBaseField.Read<String>(reader, "epb.department_order");
                string classification_order = SqlBaseField.Read<String>(reader, "epb.classification_order");

                person_SQLBase.Division = SqlBaseField.Read<String>(reader, "epb.division");
                // person_QA.department_order = Sql.Read<String>(reader, "ppb.department_order");
                // person_QA.classification_order = Sql.Read<String>(reader, "ppb.classification_order");

                person_SQLBase.EmployeeName = SqlBaseField.Read<String>(reader, "epb.name");
                person_SQLBase.WorkRole = SqlBaseField.Read<String>(reader, "epb.position");

                person_SQLBase.PhoneNumber = SqlBaseField.Read<String>(reader, "PhoneOffice");
                person_SQLBase.Ext = SqlBaseField.Read<String>(reader, "CamcoExtension");
                person_SQLBase.SpeedDial = SqlBaseField.Read<String>(reader, "CamcoSpeedDial");

                person_SQLBase.Email = SqlBaseField.Read<String>(reader, "EmailOffice");

                person_SQLBase.Status = SqlBaseField.Read<String>(reader, "epb.status");//?

                person_SQLBase.Lat = "";// Sql.Read<String>(reader, "epb.lat");
                person_SQLBase.Lon = ""; // Sql.Read<String>(reader, "epb.lon");

                People.Add(person_SQLBase);
                Count++;

            }

            // Close the database connection
            SqlBase_Connection.Close();

            return People;


        }




        public bool CheckMsSqlServerAvailablity()
        {
            try
            {
                TcpClient TcpClient = new TcpClient();

                var client = new TcpClient();


                if (!client.ConnectAsync(MsSql_SERVER, 1433).Wait(100))
                {
                    client.Close();
                    //Network up but Server Offline
                    return false;
                }
                client.Close();
                return true;
            }
            catch
            {
                //Send Message that Sql Offline
                //SocketException: A socket operation was attempted to an unreachable host
                return false;
            }

        }

        public static class SqlBaseField
        {
            public static T Read<T>(IDataReader DataReader, string FieldName)
            {
                int FieldIndex;
                try
                {
                    FieldIndex = DataReader.GetOrdinal(FieldName);
                }
                catch { return default(T); }

                if (DataReader.IsDBNull(FieldIndex))
                {
                    return default(T);
                }
                else
                {
                    object readData = DataReader.GetValue(FieldIndex);
                    if (readData is T)
                    {
                        return (T)readData;
                    }
                    else
                    {
                        try
                        {
                            return (T)Convert.ChangeType(readData, typeof(T));
                        }
                        catch (InvalidCastException)
                        {
                            return default(T);
                        }
                    }
                }
            }
        }

        public JobDetail Get_JobInfo(EfToDo db, string JobNumber)
        {

            JobDetail QAWorxJob = db.JobDetails.Create();

            //if (!CheckMsSqlServerAvailablity())
            //    return;

            //        lblitemDescription.Text = "";
            //         lblCust.Text = "";

            JobNumber = JobNumber.Replace("-", "");
            JobNumber = JobNumber.Replace(" ", "");

            string JobNumberDigits = new String(JobNumber.Where(Char.IsDigit).ToArray());

            if (JobNumberDigits == "")
                return null;

            SQLBaseConnection SqlBase_Connection = Open_SQLBase();

            //string JobQuery = "SELECT * FROM jobsheets j, contract c, originator p, originator p2 WHERE c.orderno = j.porder AND p.conid = c.custid AND p2.conid = j.mainprojmgr AND j.jobno =" + JobNumberDigits;

            string JobQuery = "SELECT j.jobno, j.porder, p.name, j.jobname, p2.name, d.full_name " +
                              "FROM jobsheets j, contract c, person p, person p2, division d " +
                              "WHERE c.orderno = j.porder " +
                              "AND p.conid = c.custid " +
                              "AND j.jobno = " + JobNumberDigits + " " +  //"JOBITP"
                              "AND p2.conid = j.mainprojmgr " +
                              "AND d.compid = c.div";

            IDbCommand cmd = SqlBase_Connection.CreateCommand();
            IDbDataParameter param = cmd.CreateParameter();
            cmd.CommandText = JobQuery;

            IDataReader reader = cmd.ExecuteReader();

            int recordCount = 0;

            while (reader.Read())
            {
                recordCount++;
                QAWorxJob.JobNo = JobNumber;
                QAWorxJob.PurchaseOrderNo = SqlBaseField.Read<String>(reader, "j.porder");
                QAWorxJob.Client = SqlBaseField.Read<String>(reader, "p.name");
                QAWorxJob.ItemDescription = SqlBaseField.Read<String>(reader, "j.jobname");
                QAWorxJob.ClientManager = SqlBaseField.Read<String>(reader, "p2.name");
                QAWorxJob.Division = SqlBaseField.Read<String>(reader, "d.full_name");
            }

            return QAWorxJob;
        }


        #endregion
    }

    public class SQLBase

    //Using ORM OO approach
    //  Start with the object model and then generate the tables, GUI & reporting using reflection.
    {
        SQLBaseConnection conn = new SQLBaseConnection();
        SQLBaseDataAdapter adaptor = new SQLBaseDataAdapter();
        DataSet ds = new DataSet();

        SQLBaseDataAdapter myAdaptor = new SQLBaseDataAdapter();
        DataSet dstemp = new DataSet();
        DataSet myDataSet = new DataSet();

        //class TestObjModel
        //{
        //    int ID { get; set; }
        //    string Data { get; set; }
        //}
        //TestObjModel obj = new TestObjModel();

        public bool ExecuteSQLTalk(string sqlCommandText = "CREATE TABLE SYSADM.TEST ( " +
                                "ID SMALLINT NOT NULL," +
                                "EMPLOYEENUMBER VARCHAR(10)," +
                                "DIVISION VARCHAR(120)," +
                                "DEPARTMENT VARCHAR(25)," +
                                "EMPLOYEENAME VARCHAR(254)," +
                                "FIRSTNAME VARCHAR(254)," +
                                "LASTNAME VARCHAR(254)," +
                                "PREFERREDNAME VARCHAR(254)," +
                                "WORKROLE VARCHAR(254)," +
                                "PHONENUMBER VARCHAR(254)," +
                                "EXT VARCHAR(254)," +
                                "EMAIL VARCHAR(254)," +
                                "LAT VARCHAR(254)," +
                                "LON VARCHAR(254)," +
                                "STATUS VARCHAR(254)," +
                                "SPEEDDIAL VARCHAR(254)" +
                                ") PCTFREE 10")
        {

            Open_SQLBase();
            bool success = true;
            SQLBaseConnection SqlBase_Connection = Open_SQLBase();

            IDbCommand sql = SqlBase_Connection.CreateCommand();
            sql.CommandText = sqlCommandText;

            // SET server APPSVR;
            // CREATE DATABASE people;
            // connect people;

            int retval = sql.ExecuteNonQuery();

            // Close the database connection
            SqlBase_Connection.Close();
            //sql.TransactionCommit();
            return success;
        }

        public SQLBaseConnection Open_SQLBase()
        {
            SQLBaseConnection SqlBase_Connection = new SQLBaseConnection();

            string SQLBase_APPSVR = @"192.168.100.15"; //APPSVR"; // 
            string SqlBase_ConnectionString = "Data Source =" + SQLBase_APPSVR + "; User = SYSADM; InitialCatalog = APPS;";
            SqlBase_Connection.ConnectionString = SqlBase_ConnectionString;
            SqlBase_Connection.Open();

            return SqlBase_Connection;
        }

        #region qaworx

        public SQLBaseConnection Open_QAWORX_SQLBase()
        {
            SQLBaseConnection SqlBase_Connection = new SQLBaseConnection();

            string QAWORX_ipAddress = @"cce-cv-svr11";// cce-svr02.camcoeng.com.au";// "cce -cv-svr06"; // "192.168.100.7";

            string SqlBase_ConnectionString = "Data Source =" + QAWORX_ipAddress + "; User = pressure; Password = pressure; InitialCatalog = camco;";
            SqlBase_Connection.ConnectionString = SqlBase_ConnectionString;
            SqlBase_Connection.Open();

            return SqlBase_Connection;
        }
        public static class SqlBaseField
        {
            public static T Read<T>(IDataReader DataReader, string FieldName, int FieldIndex = -1)
            {
                if (FieldIndex == -1)
                {
                    try
                    {
                        FieldIndex = DataReader.GetOrdinal(FieldName);
                    }
                    catch { return default(T); }
                }
                if (DataReader.IsDBNull(FieldIndex))
                {
                    return default(T);
                }
                else
                {
                    object readData = DataReader.GetValue(FieldIndex);
                    if (readData is T)
                    {
                        return (T)readData;
                    }
                    else
                    {
                        try
                        {
                            return (T)Convert.ChangeType(readData, typeof(T));
                        }
                        catch (InvalidCastException)
                        {
                            return default(T);
                        }
                    }
                }
            }
        }

        public JobFields Get_JobInfo(string JobNumber)
        {
            JobFields job = new JobFields();

            JobNumber = JobNumber.Replace("-", "");
            JobNumber = JobNumber.Replace(" ", "");

            job.JobNo = JobNumber;

            string JobNumberDigits = new String(JobNumber.Where(Char.IsDigit).ToArray());

            if (JobNumberDigits == "") return null;

            SQLBaseConnection SqlBase_Connection = Open_QAWORX_SQLBase();

            //string JobQuery = "SELECT * FROM jobsheets j, contract c, person p, person p2 WHERE c.orderno = j.porder AND p.conid = c.custid AND p2.conid = j.mainprojmgr AND j.jobno =" + JobNumberDigits;

            string JobQuery = "SELECT j.jobno, j.porder, p.name, j.jobname, p2.name, d.full_name " +
                              "FROM jobsheets j, contract c, person p, person p2, division d " +
                              "WHERE c.orderno = j.porder " +
                              "AND p.conid = c.custid " +
                              "AND j.jobno = " + JobNumberDigits + " " +  //"JOBITP"
                              "AND p2.conid = j.mainprojmgr " +
                              "AND d.compid = c.div";

            IDbCommand cmd = SqlBase_Connection.CreateCommand();
            IDbDataParameter param = cmd.CreateParameter();
            cmd.CommandText = JobQuery;

            IDataReader reader = cmd.ExecuteReader();

            int recordCount = 0;

            while (reader.Read())
            {
                recordCount++;

                job.PurchaseOrderNo = SqlBaseField.Read<String>(reader, "j.porder");
                job.Client = SqlBaseField.Read<String>(reader, "p.name");
                job.ItemDescription = SqlBaseField.Read<String>(reader, "j.jobname");
                job.ClientManager = SqlBaseField.Read<String>(reader, "p2.name");
                job.Division = SqlBaseField.Read<String>(reader, "d.full_name");
            }

            // Close the database connection
            SqlBase_Connection.Close();

            if (recordCount == 0)
            {
                return null;
            }

            return job;
        }

        public class CAR
        {
            public string GroupId { get; set; } //GROUPID
            public string Description { get; set; } //"DESCRIPTION"
            public string Active { get; set; } //"IS_ACTIVE"
            public string Comment { get; set; } //"COMMENT"


        }

        public List<CAR> CARList()
        {

            List<CAR> carlist = new List<CAR>();

            SQLBaseConnection SqlBase_Connection = Open_QAWORX_SQLBase();

            string Query = "SELECT * FROM cargroup ";

            IDbCommand cmd = SqlBase_Connection.CreateCommand();
            IDbDataParameter param = cmd.CreateParameter();
            cmd.CommandText = Query;

            IDataReader reader = cmd.ExecuteReader();

            int recordCount = 0;

            while (reader.Read())
            {
                recordCount++;
                CAR car = new CAR();
                car.GroupId = SqlBaseField.Read<String>(reader, "", 0);  //Supplier Error
                car.Description = SqlBaseField.Read<String>(reader, "", 1);
                car.Active = SqlBaseField.Read<String>(reader, "", 2);
                car.Comment = SqlBaseField.Read<String>(reader, "", 3);

                carlist.Add(car);
            }

            // Close the database connection
            SqlBase_Connection.Close();

            if (recordCount == 0)
            {
                return null;
            }

            return carlist;

        }


        public List<PersonFields> Get_People_SQLBase()
        {
            List<PersonFields> People = new List<PersonFields>();

            SQLBaseConnection SqlBase_Connection = Open_QAWORX_SQLBase();

            string People_QA_Query = "SELECT epb.oldempno, epb.name, epb.status, epb.location, epb.classification, epb.position, epb.department, epb.division, epb.department_order, epb.classification_order, " +
                                    "                epb.default_phone_id_office, epb.default_extension_id, epb.default_speed_dial_id, epb.default_email_id_office, " +
                                    "                @IF( @ISNA( epb.default_phone_id_office ), NULL, @IF( @IF( cdpo.is_private, 0, 1 ), cdpo.details, '<Private>' ) ) AS PhoneOffice, " +
                                    "                @IF( @ISNA( epb.default_extension_id ), NULL, @IF( @IF( cdpe.is_private, 0, 1 ), cdpe.details, '<Private>' ) ) AS CamcoExtension, " +
                                    "                @IF( @ISNA( epb.default_speed_dial_id ), NULL, @IF( @IF( cdps.is_private, 0, 1 ), cdps.details, '<Private>' ) ) AS CamcoSpeedDial, " +
                                    "                @IF( @ISNA( epb.default_email_id_office ), NULL, @IF( @IF( cdeo.is_private, 0, 1 ), cdeo.details, '<Private>' ) ) AS EmailOffice " +
                                    "FROM emp_phone_book epb, contact_details cdpo, contact_details cdpe, contact_details cdps, contact_details cdeo " +
                                    "WHERE cdpo.details_id = @NULLVALUE( epb.default_phone_id_office, 0 ) " +
                                    "                AND cdpe.details_id = @NULLVALUE( epb.default_extension_id, 0 ) " +
                                    "                AND cdps.details_id = @NULLVALUE( epb.default_speed_dial_id, 0 ) " +
                                    "                AND cdeo.details_id = @NULLVALUE( epb.default_email_id_office, 0 ) " +
                                    "ORDER BY 2";


            IDbCommand cmd = SqlBase_Connection.CreateCommand();
            IDbDataParameter param = cmd.CreateParameter();
            cmd.CommandText = People_QA_Query; //;txtPeopleQuery.Text;

            IDataReader reader = cmd.ExecuteReader();

            People.Clear();
            int Count = 0;

            while (reader.Read())
            {
                PersonFields person = new PersonFields();

                person.EmployeeNumber = SqlBaseField.Read<String>(reader, "epb.oldempno");
                person.Department = SqlBaseField.Read<String>(reader, "epb.department");

                string location = SqlBaseField.Read<String>(reader, "epb.location");
                string department_order = SqlBaseField.Read<String>(reader, "epb.department_order");
                string classification_order = SqlBaseField.Read<String>(reader, "epb.classification_order");

                person.Division = SqlBaseField.Read<String>(reader, "epb.division");
                // person_QA.department_order = Sql.Read<String>(reader, "ppb.department_order");
                // person_QA.classification_order = Sql.Read<String>(reader, "ppb.classification_order");

                person.EmployeeName = SqlBaseField.Read<String>(reader, "epb.name");
                person.WorkRole = SqlBaseField.Read<String>(reader, "epb.position");

                person.PhoneNumber = SqlBaseField.Read<String>(reader, "PhoneOffice");
                person.Ext = SqlBaseField.Read<String>(reader, "CamcoExtension");
                person.SpeedDial = SqlBaseField.Read<String>(reader, "CamcoSpeedDial");

                person.Email = SqlBaseField.Read<String>(reader, "EmailOffice");

                person.Status = SqlBaseField.Read<String>(reader, "epb.status");//?

                person.Lat = "";// Sql.Read<String>(reader, "epb.lat");
                person.Lon = ""; // Sql.Read<String>(reader, "epb.lon");

                People.Add(person);
                Count++;

            }

            // Close the database connection
            SqlBase_Connection.Close();

            return People;
        }

        #endregion




        //create person
        public void CreatePerson(PersonFields person)
        {
            SQLBaseConnection SqlBase_Connection = Open_SQLBase();

            string People_QA_Query = "SELECT * FROM TBL_PEOPLE ";
            IDbCommand cmd = SqlBase_Connection.CreateCommand();
            IDbDataParameter param = cmd.CreateParameter();
            cmd.CommandText = People_QA_Query; //;txtPeopleQuery.Text;


        }

        //Read
        public List<PersonFields> ReadPeople()
        {
            List<PersonFields> People = new List<PersonFields>();

            SQLBaseConnection SqlBase_Connection = Open_SQLBase();

            string People_QA_Query = "SELECT * FROM TBL_PEOPLE ";


            IDbCommand cmd = SqlBase_Connection.CreateCommand();
            IDbDataParameter param = cmd.CreateParameter();
            cmd.CommandText = People_QA_Query; //;txtPeopleQuery.Text;

            IDataReader reader = cmd.ExecuteReader();

            People.Clear();
            int Count = 0;

            while (reader.Read())
            {
                PersonFields person = new PersonFields();

                person.EmployeeNumber = SqlBaseField.Read<String>(reader, "EMPLOYEENUMBER");
                person.Department = SqlBaseField.Read<String>(reader, "DEPARTMENT");


                person.Division = SqlBaseField.Read<String>(reader, "DIVISION");
                // person_QA.department_order = Sql.Read<String>(reader, "ppb.department_order");
                // person_QA.classification_order = Sql.Read<String>(reader, "ppb.classification_order");

                person.EmployeeName = SqlBaseField.Read<String>(reader, "EMPLOYEENAME");
                person.WorkRole = SqlBaseField.Read<String>(reader, "WORKROLE");

                person.PhoneNumber = SqlBaseField.Read<String>(reader, "PHONENUMBER");
                person.Ext = SqlBaseField.Read<String>(reader, "EXT");
                person.SpeedDial = SqlBaseField.Read<String>(reader, "SPEEDDIAL");

                person.Email = SqlBaseField.Read<String>(reader, "EMAIL");

                person.Status = SqlBaseField.Read<String>(reader, "STATUS");//?

                person.Lat = "";// Sql.Read<String>(reader, "epb.lat");
                person.Lon = ""; // Sql.Read<String>(reader, "epb.lon");

                People.Add(person);
                Count++;

            }

            // Close the database connection
            SqlBase_Connection.Close();

            return People;
        }


        //Update


        //Delete


    }
}
