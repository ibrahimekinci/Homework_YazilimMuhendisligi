using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using YazilimMuhendisligiProje.Dal;
using YazilimMuhendisligiProje.Models;

namespace YazilimMuhendisligiProje.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Test
        public async Task<ActionResult> Index()
        {
            return View(await db.TestItem.ToListAsync());
        }
        public Task EmailSend(string email, string message)
        {
            string siteIsmi = "ibrahimekinci.com  |  ";
            string sonucMesaj = "";
            // Mail mesajimi olusturabilmek için MailMessage sinifi türünden bir degisken olusturmamiz gerekmektedir.
            System.Net.Mail.MailMessage mesaj = new System.Net.Mail.MailMessage();
            try
            {

                //E-Posta'yi gönderen kullanicinin kimlik bilgilerini tutar.
                System.Net.NetworkCredential gondericiBilgileri = new System.Net.NetworkCredential();
                ////gmail
                gondericiBilgileri.UserName = "ilyasekinci36@gmail.com";
                gondericiBilgileri.Password = ".irmak3636";

                //: E - Posta'nin gönderilecegi SMTP sunucu ve gönderen kullanicinin bilgilerinin yazilip, MailMessage türünde olusturulan mailin gönderildigi siniftir.
                System.Net.Mail.SmtpClient istemci = new System.Net.Mail.SmtpClient();
                //HOST
                //*Gmail için smtp.gmail.com
                //* Yahoo için smtp.mail.yahoo.com
                //* Hotmail için smtp.live.com
                //PORT
                //*587-- > gmail ve hotmail
                //*465-- > yahoo
                //25

                //Kendi Hostunda emailin ile
                //istemci.EnableSsl = false;
                //istemci.Port = 587;
                //istemci.Host = "127.0.0.1"; // Host Adresi
                //istemci.Host = "mail.herbmicro.com"; // Host Adresi
                ////****************************GMAİL******************////////////////////////////
                istemci.EnableSsl = true;
                istemci.Host = "smtp.gmail.com";
                istemci.Port = 587;

                istemci.UseDefaultCredentials = false;
                istemci.Credentials = gondericiBilgileri;
                // E-Posta'nin kimden gönderilecegi bilgisini tutar. MailAddress türünden bir degisken istemektedir.
                mesaj.From = new System.Net.Mail.MailAddress(gondericiBilgileri.UserName);
                // E-Postanin kime/kimlere gönderilecegi bilgisini tutar.
                mesaj.To.Add(new System.Net.Mail.MailAddress(email));
                // E - Posta'nin konusu bilgisini tutar.
                mesaj.Subject = siteIsmi.ToUpper() + " Kişilik Testi Sonuç";
                //Body: E - Posta'nin içerik bilgisini tutar.
                //mesaj.IsBodyHtml = true;
                mesaj.IsBodyHtml = true;
                mesaj.Body = message;

                mesaj.Priority = System.Net.Mail.MailPriority.High;
                //E-Posta'yi gönderme islemini yapar. Sunucuya göre Send ya da SendAsync metodlarindan birisi kullanilir.
                istemci.Send(mesaj);

                //            Attachments: E - Postaya eklenecek eklentilerin bilgisini tutar.
                //ePosta.Attachments.Add(new Attachment(@"C:\deneme.txt"));
            }
            catch (System.Net.Mail.SmtpException)
            {
                sonucMesaj = "Form gönderilirken hatalar oluştu...Lütfen  tekrar deneyiniz.";
            }
            catch (InvalidCastException ex)
            {
                sonucMesaj = ex.Message;

            }
            catch (Exception ex)
            {
                sonucMesaj = ex.Message;

            }
            finally
            {
                mesaj.Dispose();
            }
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}