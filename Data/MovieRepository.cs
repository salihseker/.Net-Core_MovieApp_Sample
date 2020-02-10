using System.Collections.Generic;
using System.Linq;
using NetCore_MovieApp.Models;

namespace NetCore_MovieApp.Data
{
    public static class MovieRepository
    {
        private static List<Movie> _movies = null;
        static MovieRepository()
        {
             _movies = new List<Movie>()
             {
                 new Movie{Id= 1 , Name = "Avengers: Endgame" , Description = "Avengers: Sonsuzluk Savaşı'nın ardından pek çok süper kahraman küle dönüşmüştür. Doktor Strange, Gamora, Drax, Mantis, Örümcek-Adam, Black Panther, Bucky Barnes, Groot, Scarlet Witch, Vision, Star Lord, Maria Hill, Wasp ve Nick Fury gibi pek çok kahraman, Thanos'un Sonsuzluk Eldiveni'ni ele geçirmesi ve kendi dengesini kurması yüzünden yok olmuştur ve dünya umutsuz haldedir. " , ImageUrl = "1.jpg"},
                 new Movie{Id= 2 , Name = "John Wick 3: Parabellum" , Description ="John Wick iki nedenden ötürü firaridir. Kellesi üzerine 14 milyon dolarlık açık sözleşme konulmuştur ve temel bir kuralı ihlal etmiştir; Continental Hotel'de birini öldürmüştür." , ImageUrl="2.jpg"},
                 new Movie{Id= 3 , Name = "Kaptan Marvel" , Description ="Eski bir Amerikan Hava Kuvvetleri pilotu olan Carol Danvers artık sakin bir hayat yaşayan bir kadındır. Ancak bu değişmek üzeredir. Günün birinde Kree teknolojisini içeren bir patlama sonucu özel güçler edinir. Transformasyon yeteneği kazanan kadın kısa sürede güçlerini iyilik için kullanmaya karar vererek Kaptan Marvel adını alır. O artık adaleti sağlamak ve güçsüzleri korumak için çalışacaktır." , ImageUrl="3.jpg"},
                 new Movie{Id= 4 , Name = "Örümcek Adam - Evden Uzakta" , Description ="Peter Parker arkadaşları ile birlikte yaz tatili için Avrupa gezisine çıkar. New York'tan fazlasıyla uzakta olan Peter ve arkadaşlarının başı orada da belaya girer. Bu kez de Peter Parker'ın arkadaşlarını Quentin Beck, yani namı diğer Mysterio'nun gazabından koruması gerekmektedir. Yolları Nick Fury ile Avrupa'da kesişen Peter Parker'ın başına neler gelecektir? " , ImageUrl="4.jpg"},
                 new Movie{Id= 5 , Name = "Joker" , Description ="Kalabalık içinde bile her an yalnız Arthur Fleck, bağ kurma arayışındadır. Yine de, Gotham şehrinin isli sokaklarında yürürken; bölünme ve hoşnutsuzluğun düşmanca bir yer hâline getirdiği şehrin, üzeri grafitilerle dolu toplu taşıtlarına binerken, Arthur yüzünde iki maskeyle dolaşır. Bunlardan birincisi gündüz işi için yüzüne çizdiği palyaço suratıdır. Diğeri ise asla silip çıkaramayacağı bir maskedir: Bu, çevresindeki dünyanın bir parçası gibi hissetmek için ortaya koyduğu boş çabayı yansıtan bir maskedir; hayatı tekrar tekrar yerle bir edilmiş, yanlış anlaşılmış bir adamı gizleme çabasıdır. Babasız büyüyen Arthur’ın annesi kırılgan bir kadındır ve belki de Arthur’ın en iyi arkadaşıdır. Annesi onu “Mutlu/Happy” takma adıyla çağırır; bu lakap Arthur’ın yüzüne içindeki yürek acısını gizleyen bir gülümseme yayar." , ImageUrl="5.jpg"}
             };
        }

        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie enitiy)
        {
            _movies.Add(enitiy);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(x => x.Id == id);
        }
    }
}