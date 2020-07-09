using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Top.Api;
using Top.Api.Request;
using Top.Api.Response;

namespace AliExpressAPI
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
          
        }

        const string url = "";
        const string appkey = "";
        const string secret = "";
        const string sessionKey = "";
        int i = 0;

        public void Post()
        {

            try
            {
                ITopClient client = new DefaultTopClient(url, appkey, secret);
                AliexpressSolutionProductPostRequest req = new AliexpressSolutionProductPostRequest();
                XElement stok = XElement.Load(txtTedarikciXML.Text);
                var stoklar = stok.Descendants(cmbParentElement.Text).ToList();
                foreach (var item in stoklar)
                {
                    List<string> images = new List<string>();
                    if (cmbUrunFoto1.Text != "")
                    {
                        if (item.Element(cmbUrunFoto1.Text).Value != "")
                        {
                            images.Add(item.Element(cmbUrunFoto1.Text).Value);
                        }
                    }
                    if (cmbUrunFoto2.Text != "")
                    {
                        if (item.Element(cmbUrunFoto2.Text).Value != "")
                        {
                            images.Add(item.Element(cmbUrunFoto2.Text).Value);
                        }
                    }

                    if (cmbUrunFoto3.Text != "")
                    {
                        if (item.Element(cmbUrunFoto3.Text).Value != "")
                        {
                            images.Add(item.Element(cmbUrunFoto3.Text).Value);
                        }
                    }

                    if (cmbUrunFoto4.Text != "")
                    {
                        if (item.Element(cmbUrunFoto4.Text).Value != "")
                        {
                            images.Add(item.Element(cmbUrunFoto4.Text).Value);
                        }
                    }

                    if (cmbUrunFoto5.Text != "")
                    {
                        if (item.Element(cmbUrunFoto5.Text).Value != "")
                        {
                            images.Add(item.Element(cmbUrunFoto5.Text).Value);
                        }
                    }

                    if (cmbUrunFoto6.Text != "")
                    {
                        if (item.Element(cmbUrunFoto6.Text).Value != "")
                        {
                            images.Add(item.Element(cmbUrunFoto6.Text).Value);
                        }
                    }


                    List<AliexpressSolutionProductPostRequest.SkuInfoDtoDomain> info = new List<AliexpressSolutionProductPostRequest.SkuInfoDtoDomain>();
                    AliexpressSolutionProductPostRequest.SkuInfoDtoDomain skuInfo = new AliexpressSolutionProductPostRequest.SkuInfoDtoDomain();

                    Random rastgele = new Random();
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i <= 12; i++)
                    {
                        int ascii = rastgele.Next(65, 91);
                        char karakter = Convert.ToChar(ascii);
                        sb.Append(karakter);
                    }
                    skuInfo.SkuCode = sb.ToString();
                    skuInfo.Price = item.Element(cmbUrunFiyat.Text).Value;
                    skuInfo.Inventory = long.Parse(item.Element(cmbStokAded.Text).Value);
                    info.Add(skuInfo);

                    AliexpressSolutionProductPostRequest.PostProductRequestDtoDomain obj1 = new AliexpressSolutionProductPostRequest.PostProductRequestDtoDomain();
                    obj1.Subject = item.Element(cmbUrunAdi.Text).Value;
                    obj1.Description = item.Element(cmbUrunAciklama.Text).Value;
                    obj1.Language = txtUrunDil.Text;
                    obj1.MainImageUrlsList = images;
                    obj1.SkuInfoList = info;
                    obj1.InventoryDeductionStrategy = "payment_success_deduct";
                    obj1.PackageHeight = long.Parse(item.Element(cmbPaketYuksekligi.Text).Value);
                    obj1.PackageLength = long.Parse(item.Element(cmbPaketUzunlugu.Text).Value);
                    obj1.PackageWidth = long.Parse(item.Element(cmbPaketGenisligi.Text).Value);
                    obj1.Weight = item.Element(cmbPaketAgirligi.Text).Value;
                    obj1.FreightTemplateId = long.Parse(txtKargoSablonID.Text.Trim());
                    obj1.ShippingLeadTime = long.Parse(txtKargoyaVerilisSuresi.Text.Trim());
                    obj1.ServicePolicyId = long.Parse((txtHizmetPolitikaNo.Text.Trim()));
                    obj1.BrandName = item.Element(cmbUrunMarka.Text).Value;
                    req.PostProductRequest_ = obj1;

                    AliexpressSolutionProductPostResponse rsp = client.Execute(req, sessionKey);

                    if (!rsp.IsError)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = item.Element(cmbUrunAdi.Text).Value;
                        dataGridView1.Rows[i].Cells[1].Value = "Başarılı";
                        i++;
                    }
                    else
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = item.Element(cmbUrunAdi.Text).Value;
                        dataGridView1.Rows[i].Cells[1].Value = "Başarısız";
                        dataGridView1.Rows[i].Cells[2].Value = rsp.ErrMsg;
                        dataGridView1.Rows[i].Cells[3].Value = rsp.ErrCode;
                        i++;
                    }
                    break;
                }
                MessageBox.Show("İşlem Başarılı!");
            }
            catch (Exception)
            {

                MessageBox.Show("İşlem sırasında hata oluştu!");
            }

        }
        public void ReadXML()
        {
            try
            {
                cmbPaketAgirligi.Items.Clear();
                cmbPaketGenisligi.Items.Clear();
                cmbPaketUzunlugu.Items.Clear();
                cmbPaketYuksekligi.Items.Clear();
                cmbParentElement.Items.Clear();
                cmbStokAded.Items.Clear();
                cmbUrunAciklama.Items.Clear();
                cmbUrunAdi.Items.Clear();
                cmbUrunFiyat.Items.Clear();
                cmbUrunFoto1.Items.Clear();
                cmbUrunFoto2.Items.Clear();
                cmbUrunFoto3.Items.Clear();
                cmbUrunFoto4.Items.Clear();
                cmbUrunFoto5.Items.Clear();
                cmbUrunFoto6.Items.Clear();
                cmbUrunMarka.Items.Clear();
                XmlTextReader reader = new XmlTextReader(txtTedarikciXML.Text);
                HashSet<string> elementName = new HashSet<string>();
             
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                elementName.Add(reader.Name);
                                break;
                        }
                    }
               
                    foreach (var item in elementName)
                     {
                            cmbPaketAgirligi.Items.Add(item);
                            cmbPaketGenisligi.Items.Add(item);
                            cmbPaketUzunlugu.Items.Add(item);
                            cmbPaketYuksekligi.Items.Add(item);
                            cmbParentElement.Items.Add(item);
                            cmbStokAded.Items.Add(item);
                            cmbUrunAciklama.Items.Add(item);
                            cmbUrunMarka.Items.Add(item);
                            cmbUrunAdi.Items.Add(item);
                            cmbUrunFiyat.Items.Add(item);
                            cmbUrunFoto1.Items.Add(item);
                            cmbUrunFoto2.Items.Add(item);
                            cmbUrunFoto3.Items.Add(item);
                            cmbUrunFoto4.Items.Add(item);
                            cmbUrunFoto5.Items.Add(item);
                            cmbUrunFoto6.Items.Add(item);
                    }
                
                MessageBox.Show("Ürün Okuma işlemi başarılı!");
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün okumada bir hata gerçekleşti!");
            }

        }
        private void btnXmlOku_Click(object sender, EventArgs e)
        {
            ReadXML();
        }
        private void brnUrunGonder_Click(object sender, EventArgs e)
        {
            Post();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
