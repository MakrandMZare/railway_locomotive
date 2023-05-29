﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class Master_Assembly_NonStock_Master : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Fill_Data();
        }
    }
    public void Insertion()
    {

        Cls_Assembly_NonStock_Master c = new Cls_Assembly_NonStock_Master();
        c.NameOfAssembly = txtNameOfItem.Text;
        c.Insert_Data();
        Fill_Data();
        txtNameOfItem.Text = "";
    }
    public void Updation()
    {
        Cls_Assembly_NonStock_Master c = new Cls_Assembly_NonStock_Master();
        c.Id_NonStock = ViewState["Id"].ToString();
        c.NameOfAssembly = txtNameOfItem.Text;
        c.Update_Data();
        Fill_Data();
        btnSave.Text = "Insert";
        txtNameOfItem.Text = "";
    }
    public void Fill_Data()
    {
        Cls_Assembly_NonStock_Master c = new Cls_Assembly_NonStock_Master();
        gv1.DataSource = c.Select_Data();
        gv1.DataBind();

    }

    protected void gv1_OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        txtNameOfItem.Text = gv1.Rows[e.NewEditIndex].Cells[1].Text;
        ViewState["Id"] = gv1.DataKeys[e.NewEditIndex].Value.ToString();
        btnSave.Text = "Update";

    }
    protected void gv1_OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Cls_Assembly_NonStock_Master c = new Cls_Assembly_NonStock_Master();
        c.Id_NonStock = gv1.DataKeys[e.RowIndex].Value.ToString();
        c.Delete_Data();
        Fill_Data();
        txtNameOfItem.Text = "";
    }
    protected void btnCancel_OnClick(object sender, EventArgs e)
    {
        btnSave.Text = "Insert";
        txtNameOfItem.Text = "";
    }
    protected void btnSave_OnClick(object sender, EventArgs e)
    {
        if (btnSave.Text == "Insert")
        {
            Insertion();
        }
        else if (btnSave.Text == "Update")
        {
            Updation();
        }
    }
}
