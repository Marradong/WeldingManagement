//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v4.1.2.0
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Welding.DAL
{
   public partial class Current_Qualification
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Current_Qualification()
      {
         Welder_Qualification = new System.Collections.Generic.HashSet<global::Welding.DAL.Welder_Qualification>();
         NDT_Record = new System.Collections.Generic.HashSet<global::Welding.DAL.NDT_Record>();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Current_Qualification CreateCurrent_QualificationUnsafe()
      {
         return new Current_Qualification();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="person"></param>
      public Current_Qualification(global::Welding.DAL.Person person)
      {
         if (person == null) throw new ArgumentNullException(nameof(person));
         this.Person = person;
         person.Current_Qualification.Add(this);

         Welder_Qualification = new System.Collections.Generic.HashSet<global::Welding.DAL.Welder_Qualification>();
         NDT_Record = new System.Collections.Generic.HashSet<global::Welding.DAL.NDT_Record>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="person"></param>
      public static Current_Qualification Create(global::Welding.DAL.Person person)
      {
         return new Current_Qualification(person);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Indexed, Required
      /// Unique identifier
      /// </summary>
      [Key]
      [Required]
      [System.ComponentModel.Description("Unique identifier")]
      public long Id { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual ICollection<global::Welding.DAL.NDT_Record> NDT_Record { get; private set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Welding.DAL.Person Person { get; set; }

      public virtual ICollection<global::Welding.DAL.Welder_Qualification> Welder_Qualification { get; private set; }

   }
}
