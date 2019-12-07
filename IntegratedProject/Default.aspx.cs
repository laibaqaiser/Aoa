using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
public partial class _Default : System.Web.UI.Page
{
    private static string file;
    HuffmanTree huffmantree = new HuffmanTree();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Decode_Click(object sender, EventArgs e)
    {
        huffmantree.tree(file);
        huffmantree.Encoding(file);
        // Console.WriteLine("");
        //Console.WriteLine("You have 3 attempts to decode");
        int tries = 1;
        while (tries <= 3)
        {
            //Console.Write("Enter key to decode ");
            string key = Key.Text;
            if (key == "123")
            {
                // Console.Write("You entered a valid key.");
                string DecodedData = huffmantree.Decoding();
                data.InnerText = DecodedData;
                break;
            }
            else
            {
                // Console.WriteLine("You entered an Invalid key!!!");
                tries++;
            }
        }
    }

    protected void Upload_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            try
            {
                string filename = Path.GetFileName(FileUpload1.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/") + filename);
                file = System.IO.File.ReadAllText(Server.MapPath("~/") + filename);
                huffmantree.tree(file);
                string EncyptedData = huffmantree.Encoding(file);
                data.InnerText = EncyptedData;
            }
            catch (Exception ex)
            {
                data.InnerText = "Upload Status:The file could not be uploaded.The following error occured:" + ex.Message;
            }

        }
    }
}