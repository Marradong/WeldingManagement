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
   public partial class Attachment
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected Attachment()
      {
         Welder_Qualification = new System.Collections.Generic.HashSet<global::Welding.DAL.Welder_Qualification>();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static Attachment CreateAttachmentUnsafe()
      {
         return new Attachment();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="datasheet"></param>
      /// <param name="wpqr"></param>
      /// <param name="wps"></param>
      /// <param name="consumable"></param>
      public Attachment(global::Welding.DAL.Datasheet datasheet, global::Welding.DAL.WPQR wpqr, global::Welding.DAL.WPS wps, global::Welding.DAL.Consumable consumable)
      {
         if (datasheet == null) throw new ArgumentNullException(nameof(datasheet));
         this.Datasheet = datasheet;
         datasheet.Attachments.Add(this);

         if (wpqr == null) throw new ArgumentNullException(nameof(wpqr));
         this.WPQR = wpqr;
         wpqr.Attachments.Add(this);

         if (wps == null) throw new ArgumentNullException(nameof(wps));
         this.WPS = wps;
         wps.Attachments.Add(this);

         if (consumable == null) throw new ArgumentNullException(nameof(consumable));
         this.Consumable = consumable;
         consumable.Attachments.Add(this);

         Welder_Qualification = new System.Collections.Generic.HashSet<global::Welding.DAL.Welder_Qualification>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="datasheet"></param>
      /// <param name="wpqr"></param>
      /// <param name="wps"></param>
      /// <param name="consumable"></param>
      public static Attachment Create(global::Welding.DAL.Datasheet datasheet, global::Welding.DAL.WPQR wpqr, global::Welding.DAL.WPS wps, global::Welding.DAL.Consumable consumable)
      {
         return new Attachment(datasheet, wpqr, wps, consumable);
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

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Welding.DAL.Consumable Consumable { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Welding.DAL.Datasheet Datasheet { get; set; }

      public virtual ICollection<global::Welding.DAL.Welder_Qualification> Welder_Qualification { get; private set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Welding.DAL.WPQR WPQR { get; set; }

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Welding.DAL.WPS WPS { get; set; }

   }
}

