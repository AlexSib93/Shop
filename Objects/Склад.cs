﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Интернет_магазин
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Склад.
    /// </summary>
    // *** Start programmer edit section *** (Склад CustomAttributes)

    // *** End programmer edit section *** (Склад CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СкладE", new string[] {
            "ID as \'ID\'",
            "Адресс as \'Адресс\'"})]
    [AssociatedDetailViewAttribute("СкладE", "ТоварНаСкладе", "ТоварНаСкладеE", true, "", "Товар на складе", true, new string[] {
            ""})]
    [View("СкладL", new string[] {
            "ID as \'ID\'",
            "Адресс as \'Адресс\'"})]
    public class Склад : ICSSoft.STORMNET.DataObject
    {
        
        private int fID;
        
        private string fАдресс;
        
        private IIS.Интернет_магазин.DetailArrayOfТоварНаСкладе fТоварНаСкладе;
        
        // *** Start programmer edit section *** (Склад CustomMembers)

        // *** End programmer edit section *** (Склад CustomMembers)

        
        /// <summary>
        /// ID.
        /// </summary>
        // *** Start programmer edit section *** (Склад.ID CustomAttributes)

        // *** End programmer edit section *** (Склад.ID CustomAttributes)
        [NotNull()]
        public virtual int ID
        {
            get
            {
                // *** Start programmer edit section *** (Склад.ID Get start)

                // *** End programmer edit section *** (Склад.ID Get start)
                int result = this.fID;
                // *** Start programmer edit section *** (Склад.ID Get end)

                // *** End programmer edit section *** (Склад.ID Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.ID Set start)

                // *** End programmer edit section *** (Склад.ID Set start)
                this.fID = value;
                // *** Start programmer edit section *** (Склад.ID Set end)

                // *** End programmer edit section *** (Склад.ID Set end)
            }
        }
        
        /// <summary>
        /// Адресс.
        /// </summary>
        // *** Start programmer edit section *** (Склад.Адресс CustomAttributes)

        // *** End programmer edit section *** (Склад.Адресс CustomAttributes)
        [StrLen(255)]
        [NotNull()]
        public virtual string Адресс
        {
            get
            {
                // *** Start programmer edit section *** (Склад.Адресс Get start)

                // *** End programmer edit section *** (Склад.Адресс Get start)
                string result = this.fАдресс;
                // *** Start programmer edit section *** (Склад.Адресс Get end)

                // *** End programmer edit section *** (Склад.Адресс Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.Адресс Set start)

                // *** End programmer edit section *** (Склад.Адресс Set start)
                this.fАдресс = value;
                // *** Start programmer edit section *** (Склад.Адресс Set end)

                // *** End programmer edit section *** (Склад.Адресс Set end)
            }
        }
        
        /// <summary>
        /// Склад.
        /// </summary>
        // *** Start programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)

        // *** End programmer edit section *** (Склад.ТоварНаСкладе CustomAttributes)
        public virtual IIS.Интернет_магазин.DetailArrayOfТоварНаСкладе ТоварНаСкладе
        {
            get
            {
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Get start)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Get start)
                if ((this.fТоварНаСкладе == null))
                {
                    this.fТоварНаСкладе = new IIS.Интернет_магазин.DetailArrayOfТоварНаСкладе(this);
                }
                IIS.Интернет_магазин.DetailArrayOfТоварНаСкладе result = this.fТоварНаСкладе;
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Get end)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Set start)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Set start)
                this.fТоварНаСкладе = value;
                // *** Start programmer edit section *** (Склад.ТоварНаСкладе Set end)

                // *** End programmer edit section *** (Склад.ТоварНаСкладе Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СкладE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладE", typeof(IIS.Интернет_магазин.Склад));
                }
            }
            
            /// <summary>
            /// "СкладL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СкладL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СкладL", typeof(IIS.Интернет_магазин.Склад));
                }
            }
        }
    }
}
