using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;
using Color = System.Drawing.Color;

namespace QrCodeWinForm
{
    public partial class Form1 : Form, IMessageFilter
    {
        int remaniHeight = 0;
        float dpiY = 0f;
        float dpiX = 0f;
        double width = 0d;
        double height = 0d;
        int remainCout = 0;
        int alreadyPrintCout = 0;
        public Form1()
        {
            InitializeComponent();
            printDocument1.BeginPrint += PrintDocument1_BeginPrint;
        }

        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            alreadyPrintCout = 0;
            remainCout = 0;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            ItemMaster itemMaster = new ItemMaster
            {
                行号 = dataGridView1.Rows[alreadyPrintCout].Cells[0].Value.ToString(),
                料号 = dataGridView1.Rows[alreadyPrintCout].Cells[1].Value.ToString(),
                品名 = dataGridView1.Rows[alreadyPrintCout].Cells[2].Value.ToString(),
                序列号 = dataGridView1.Rows[alreadyPrintCout].Cells[3].Value.ToString(),
                供应商编码 = dataGridView1.Rows[alreadyPrintCout].Cells[4].Value.ToString()
            };
            var g = e.Graphics;
            //var source = (dataGridView1.DataSource as List<ItemMaster>).ToList();

            //  DrawQrcode(g, source[alreadyPrintCout]);
            DrawQrcode(g, itemMaster);
            alreadyPrintCout += 1;
           // remainCout = source.Count() - alreadyPrintCout;
            remainCout = dataGridView1.Rows.Count-1 - alreadyPrintCout;
            e.HasMorePages = remainCout > 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("没有任何可打印数据，请添加数据");
                return;
            }
            remainCout = dataGridView1.Rows.Count;
            remaniHeight = (int)Math.Floor(100 * 100 * dpiY * (3 / 2.54));
            printDialog1.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            printDialog1.ShowDialog();
            printDialog1.Document = printDocument1;
            pageSetupDialog1.PrinterSettings = printDialog1.PrinterSettings;
            pageSetupDialog1.PageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            pageSetupDialog1.AllowMargins = true;
            pageSetupDialog1.AllowOrientation = true;
            pageSetupDialog1.AllowPaper = true;
            pageSetupDialog1.AllowPrinter = true;

            pageSetupDialog1.ShowDialog();
            pageSetupDialog1.Document = printDocument1;
            //  pageSetupDialog1.PageSettings.PaperSize = new PaperSize("40*30", 157, 118);
            printDocument1.EndPrint += PrintDocument1_EndPrint;
            //pageSetupDialog1.ShowDialog();

            //   MessageBox.Show(pageSetupDialog1.PageSettings.Margins.Top.ToString());

            printDocument1.Print();


            //  pageSetupDialog1.ShowDialog();


            //    pageSetupDialog1.Document.Print();
        }

        private void PrintDocument1_EndPrint(object sender, PrintEventArgs e)
        {

            MessageBox.Show("打印完成");

            // remaniHeight = 350f;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            dpiY = g.DpiY;
            dpiX = g.DpiX;
            width = Math.Floor(4 / 2.54 * dpiX);
            height = Math.Floor(3 / 2.54 * dpiY);



        }

        private void PrintViewBtn_Click(object sender, EventArgs e)
        {
            remainCout = dataGridView1.Rows.Count;
            remaniHeight = (int)Math.Floor(100 * 100 * dpiY * (3 / 2.54));
            printDialog1.Document = printDocument1;
            // printDialog1.ShowDialog(); 
            printDialog1.PrinterSettings.PrinterName = "Microsoft XPS Document Writer";
            pageSetupDialog1.PrinterSettings = printDialog1.PrinterSettings;

            pageSetupDialog1.PageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            pageSetupDialog1.AllowMargins = true;
            pageSetupDialog1.AllowOrientation = true;
            pageSetupDialog1.AllowPaper = true;
            pageSetupDialog1.AllowPrinter = true;
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.PageSettings.PaperSize = new PaperSize("40*30", 157, 118);
            //pageSetupDialog1.ShowDialog();

            //   MessageBox.Show(pageSetupDialog1.PageSettings.Margins.Top.ToString());
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg >= 513 && m.Msg <= 515)

            {

                return true;

            }

            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.AddMessageFilter(this);
            //  MessageBox.Show("helloworld");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.RemoveMessageFilter(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //  DrawQrcode(pictureBox1.CreateGraphics(), "[16606030010]", "[铲斗油缸~LG6065W.31~组合件]", "[1001001719]", "[1001001719]", 14);

            //   DrawQrcode("[16606030010]", "[铲斗油缸~LG6065W.31~组合件]", "[1001001719]", "[1001001719]", 16);



        }
        private void DrawQrcode(Graphics g, ItemMaster itemMaster)
        {

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();
            qRCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE; //二维码编码方式
            qRCodeEncoder.QRCodeScale = 4; //每个小方格的预设宽度（像素），正整数
            qRCodeEncoder.QRCodeVersion = 0; //二维码版本号 0-40
            qRCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M; //纠错码等级
            g.DrawImage(qRCodeEncoder.Encode("PC" + itemMaster.料号 + "," + itemMaster.品名 + ",SN" + itemMaster.序列号 + ",VC" + itemMaster.供应商编码, Encoding.UTF8), 10, 20, 80, 80);
            g.DrawString(itemMaster.料号, new Font("微软雅黑", 5), new SolidBrush(Color.Black), new Point(90, 20));
            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Near;
            stringFormat.FormatFlags = StringFormatFlags.LineLimit;
            string printString = string.Format("[{0}]", itemMaster.品名);
            Rectangle r = new Rectangle(90, 30, 50, 60);
            g.DrawString(printString, new Font("宋体", 6), new SolidBrush(Color.Black), r, stringFormat);

            g.DrawString("SN:\n" + string.Format("[{0}]", itemMaster.序列号), new Font("微软雅黑", 5), new SolidBrush(Color.Black), new Point(90, 80));
            //  g.DrawString(VC, new Font("宋体", 5), new SolidBrush(Color.Black), new Point(90, 30 + 10 * (cout + 2)));
            g.DrawRectangle(new Pen(new SolidBrush(System.Drawing.Color.Black), 0.3F), new Rectangle(new Point(5, 5), new Size((int)width - 10, (int)height - 10)));
            g.Dispose();

        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            if (openQrExcelDg.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = ExcelTool.ReadExcelAll(openQrExcelDg.FileName);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new List<ItemMaster>();
            var b = new List<ItemMaster>();
            dataGridView1.DataSource = a;
            b.Add(new ItemMaster { 行号 = "11" });
            dataGridView1.DataSource = b;
            ((List<ItemMaster>)dataGridView1.DataSource).Add(new ItemMaster { 行号="11" });
            
        }
    }




















}
