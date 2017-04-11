using System;
using System.Data.Entity.Migrations;
using System.Linq;
using YazilimMuhendisligiProje.Dal.Initializer;
using YazilimMuhendisligiProje.Models;

namespace YazilimMuhendisligiProje.Dal
{
    public class AppSeed
    {
        private AppDbContext db;
        public AppSeed(AppDbContext db)
        {
            this.db = db;
            AllStart();
        }
        private void AllStart()
        {
            //adminler eklendi
            var appSeedController = new AppSeedController(db);
            //Soru ve seçenekler
            db.TestItem.AddOrUpdate(
                new TestItemModels
                {
                    Question = "Aşağıdaki beyitlerden hangisi sizi daha iyi anlatır ?",
                    OptionA = "Güçlü, kararlı, girişken ve doğuştan liderim Düşer kalkar, yoluma devam ederim",
                    OptionB = "Hayata anlamlı renkler katar eğlenceyi severim Ömür boyu herkesin mutlu ve neşeli olmasını dilerim.",
                    OptionC = "Her anımı huzurlu ve sakin geçirmek isterim Kavga gürültü sevmem, işlerimde en kolay yolu seçerim.",
                    OptionD = "Her şeyin mükemmel, düzgün, kusursuz olmasını isterim İlişkilerimde saygılı ve mesafeli olmayı severim."
                },
               new TestItemModels
               {
                   Question = "Genellikle hangi tempoda ve nasıl konuşursunuz?",
                   OptionA = "Hızlı ve sonuca yönelik",
                   OptionB = "Çok hızlı, heyecanlı ve eğlenceli",
                   OptionC = "Daha yavaş ve sakin",
                   OptionD = "Normal ve söyleyeceklerimi aklımda tartarak"
               },
               new TestItemModels
               {
                   Question = "Bir işe motive olmanızı sağlayan en önemli unsur hangisidir?",
                   OptionA = "Sonuçları düşünmek",
                   OptionB = "Onaylanmak, takdir edilmek",
                   OptionC = "Guruptaki arkadaşlarımın desteği",
                   OptionD = "Etkinlik, düzen ve disiplin"
               },
               new TestItemModels
               {
                   Question = "Çalışma tarzınız hangisine uygundur?",
                   OptionA = "Yoğun ve hızlıyımdır. Aynı anda birkaç iş bir arada yapabilirim.",
                   OptionB = "Özgür bir ortamda çalışırım. İnsan ilişkileri odaklıyımdır.",
                   OptionC = "Ön planda olmayan; ama gruba her türlü desteği veren bir yapım vardır.",
                   OptionD = "Ayrıntıları önemserim ve tek bir konuya daklanarak çalışırım."
               },
               new TestItemModels
               {
                   Question = "Çalışma temponuzu nasıl değerlendiriyorsunuz?",
                   OptionA = "Hızlı bir tempoda çalışır, çabuk karar almayı severim.",
                   OptionB = "İşlerin, rutin ve sıkıcı olmadığı ortamlarda yüksek motivasyonla çalışırım.",
                   OptionC = "Nadiren aceleciyimdir. Geçde olsa üstlendiğim işi bitiririm.",
                   OptionD = "Ayrıntılı düşünerek karar veririm. İş bitirici bir tempoyla çalışırım."
               }
            );
            db.SaveChanges();
        }
    }
}
