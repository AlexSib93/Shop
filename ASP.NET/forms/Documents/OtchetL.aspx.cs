﻿/*flexberryautogenerated="true"*/
namespace IIS.Интернет_магазин
{
    using System;
    using ICSSoft.STORMNET.Web.Controls;

    using Resources;

    public partial class ОтчетL : BaseListForm<Отчет>
    {
        /// <summary>
        /// Конструктор без параметров,
        /// инициализирует свойства, соответствующие конкретной форме.
        /// </summary>
        public ОтчетL() : base(Отчет.Views.ОтчетL)
        {
            EditPage = ОтчетE.FormPath;
        }
                
        /// <summary>
        /// Путь до формы.
        /// </summary>
        public static string FormPath
        {
            get { return "~/forms/Documents/OtchetL.aspx"; }
        }

        /// <summary>
        /// Вызывается самым первым в Page_Load.
        /// </summary>
        protected override void Preload()
        {
        }

        /// <summary>
        /// Вызывается самым последним в Page_Load.
        /// </summary>
        protected override void Postload()
        {
        }
    }
}
