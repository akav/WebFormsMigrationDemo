using Mobilize.WebMap.Common.Attributes;
using System;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. 
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiringTrackingSite
{


    public partial class ClientsListForm
    {

        [Intercepted]

        /// <summary>
        /// IdFilter control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.TextBox IdFilter
        { get; set; }

        [Intercepted]

        /// <summary>
        /// NameFilter control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.TextBox NameFilter
        { get; set; }

        [Intercepted]

        /// <summary>
        /// PhoneFilter control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.TextBox PhoneFilter
        { get; set; }

        [Intercepted]

        /// <summary>
        /// EmailFilter control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.TextBox EmailFilter
        { get; set; }

        [Intercepted]

        /// <summary>
        /// WebsiteFilter control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.TextBox WebsiteFilter
        { get; set; }

        [Intercepted]

        /// <summary>
        /// ContactNameFilter control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.TextBox ContactNameFilter
        { get; set; }

        [Intercepted]

        /// <summary>
        /// btnFilter control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.Button btnFilter
        { get; set; }

        [Intercepted]

        /// <summary>
        /// DataList1 control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.DataList DataList1
        { get; set; }

        [Intercepted]

        /// <summary>
        /// AddNewButton control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.LinkButton AddNewButton
        { get; set; }

        [Intercepted]

        /// <summary>
        /// ClientsDataSource control.
        /// </summary>
        /// <remarks>
        /// Auto-generated field.
        /// To modify move field declaration from designer file to code-behind file.
        /// </remarks>
        protected
        Mobilize.Web.UI.WebControls.SqlDataSource ClientsDataSource
        { get; set; }

        
        [Intercepted]
        protected EventHandler Details_Click { get; set; }
        public ClientsListForm()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.IdFilter = new Mobilize.Web.UI.WebControls.TextBox();
            this.NameFilter = new Mobilize.Web.UI.WebControls.TextBox();
            this.PhoneFilter = new Mobilize.Web.UI.WebControls.TextBox();
            this.EmailFilter = new Mobilize.Web.UI.WebControls.TextBox();
            this.WebsiteFilter = new Mobilize.Web.UI.WebControls.TextBox();
            this.ContactNameFilter = new Mobilize.Web.UI.WebControls.TextBox();
            this.btnFilter = new Mobilize.Web.UI.WebControls.Button();
            this.btnFilter.Click += btnFilter_Click;
            this.btnFilter.Text = "Filter";
            this.DataList1 = new Mobilize.Web.UI.WebControls.DataList();
            this.AddNewButton = new Mobilize.Web.UI.WebControls.LinkButton();
            this.AddNewButton.Text = "Add new client";
            this.AddNewButton.Click += AddNewButton_Click;
            this.ClientsDataSource = new Mobilize.Web.UI.WebControls.SqlDataSource();
            this.ClientsDataSource.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["HiringConnectionString"].ConnectionString;
            this.DataList1.DataSource = this.ClientsDataSource;
            this.Details_Click += Details_ClickHandler;

        }
    }
}