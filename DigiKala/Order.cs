using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigiKala
{
    public partial class Order : Form
    {
        #region [- ctor -]
        public Order()
        {
            InitializeComponent();
            Ref_OrderMaster = new Model.Helper.SPHelper.Order.InsertOrderMaster();
            Masters = new List<Model.Helper.SPHelper.Order.InsertOrderMaster>();
            Ref_OrderDetail = new Model.Helper.SPHelper.Order.InsertOrderDetail();
            Details = new List<Model.Helper.SPHelper.Order.InsertOrderDetail>();
            Ref_OderViewModel = new ViewModel.Order.OrderViewModel();
        }
        #endregion
        public Model.Helper.SPHelper.Order.InsertOrderMaster Ref_OrderMaster { get; set; }
        public List<Model.Helper.SPHelper.Order.InsertOrderMaster> Masters { get; set; }
        public Model.Helper.SPHelper.Order.InsertOrderDetail Ref_OrderDetail { get; set; }
        public List<Model.Helper.SPHelper.Order.InsertOrderDetail> Details { get; set; }
        public ViewModel.Order.OrderViewModel Ref_OderViewModel { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Ref_OrderMaster.Person_Ref = 1;
            Ref_OrderMaster.TotalPrice = 6545000;
            //----------------------------------------------------
            Ref_OrderDetail.Product_Ref = 5;
            Ref_OrderDetail.Quantiy = 124;
            Ref_OrderDetail.UnitPrice = 45000;
            Ref_OrderDetail.Discount = 120;
            //------------------------------------------------------
            Masters.Add(Ref_OrderMaster);
            Details.Add(Ref_OrderDetail);
            Ref_OderViewModel.Save(Masters, Details);



        }
    }
}
