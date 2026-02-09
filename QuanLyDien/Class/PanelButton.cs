using QuanLyDien.Test;
using System;
using System.Drawing;
using System.Windows.Forms;

public class PanelMenuButton
{
    private Panel panel;
    private Form form;
    private FormMain main;

    public PanelMenuButton(Panel p, Form f, FormMain m)
    {
        panel = p;
        form = f;
        main = m;

        panel.Cursor = Cursors.Hand; //Cursors la con trỏ chuột  Hand là con trỏ hình bàn tay 
        panel.Click += Click;

        // cho tất cả control trong panel cũng click được
        foreach (Control c in panel.Controls)
        {
            c.Click += Click;
        }
    }

    private void Click(object sender, System.EventArgs e)
    {
        main.OpenChildForm(form);
    }
}
