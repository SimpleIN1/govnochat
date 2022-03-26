using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace newchat2
{
    class TrashFunction
    {
    }
#if false
    private void fileRead()
    {
        if (_path_to_file != null)
        {
            label4.Text = _path_to_file;
            using (FileStream fout = new FileStream(_path_to_file, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader str1 = new StreamReader(fout))
                {
                    string s;
                    int i_count = 0;
                    while ((s = str1.ReadLine()) != null)
                        if (++i_count > _count_written) { listBox1.Items.Add(s); label4.Text = Convert.ToString(i_count); }
                    _count_written += (i_count - _count_written);
                }
            }
        }
    }

    private void fileWrite()
    {
        if (_path_to_file != null)
        {
            FileStream fin;
            try
            {
                fin = new FileStream(_path_to_file, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                // C:/Users/griha/Desktop/data.txt
            }
            catch (IOException err)
            {
                MessageBox.Show(Convert.ToString(err));
                return;
            }
            using (StreamWriter str1 = new StreamWriter(fin))
            {
                if (message.Text != "Message")
                {
                    str1.Write(_name_user + " -> " + message.Text + '\n');
                    listBox1.Items.Add(_name_user + " -> " + message.Text + '\n');
                    listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    ++_count_written;
                }
                else
                    MessageBox.Show("Enter something!");
            }
            fin.Close();
        }
    }

    private void download_file_from_ftp()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://rudy.zzz.com.ua/wwwgos.zzz.com.ua/test/data.txt");

        request.Method = WebRequestMethods.Ftp.DownloadFile;
        //request.Method = WebRequestMethods.Ftp.UploadFile;
        request.Credentials = new NetworkCredential("myhost1", "Prq2pw_5zzz");

        //using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        //{
        //    Stream responseto = response.GetResponseStream();

        //}

        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        {
            Stream responseStream = response.GetResponseStream();
            using (FileStream fs = new FileStream("../../DATA/data.txt", FileMode.Create))
            {
                byte[] buffer = new byte[64];
                int size = 0;
                while ((size = responseStream.Read(buffer, 0, buffer.Length)) > 0)
                    fs.Write(buffer, 0, size);
            }
        }

    }

    private void upload_file_to_ftp()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://rudy.zzz.com.ua/wwwgos.zzz.com.ua/test/data.txt");
        request.Method = WebRequestMethods.Ftp.UploadFile;
        request.Credentials = new NetworkCredential("myhost1", "Prq2pw_5zzz");

        using (FileStream fs = new FileStream("../../DATA/data.txt", FileMode.Open, FileAccess.ReadWrite))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Write(buffer, 0, buffer.Length);
            request.ContentLength = buffer.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
#endif
}
