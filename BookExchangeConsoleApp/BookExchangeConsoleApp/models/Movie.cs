using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExchangeConsoleApp.models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string publisher { get; set; }

        public string description { get; set; }

        public string author { get; set; }

        public double rating { get; set; }

        public Movie(){}

        public Movie(int id, string name, string publisher, string description, string author,int rating)
        {
            Id = id;
            Name = name;
            this.publisher = publisher;
            this.description = description;
            this.author = author;
            this.rating = rating;
        }


        public class MovieCollection
        {
            public List<Movie> Movies { get; set; }

            public MovieCollection()
            {
                Movies = new List<Movie>();

                // 10 adet Türkçe film ekleyelim
                AddMovie(new Movie(1, "Vizontele", "Med Yapım", "Küçük bir köyde televizyonun gelmesiyle yaşanan komik olayları konu alan bir film.", "Yılmaz Erdoğan",5));
                AddMovie(new Movie(2, "G.O.R.A.", "Böcek Film", "Dünya dışından gelen uzaylılarla yaşanan komik maceraları konu alan bir bilim kurgu komedisi.", "Cem Yılmaz",4));
                AddMovie(new Movie(3, "Eyyvah Eyvah", "BKM", "Bir müzisyenin başından geçen olayları konu alan bir komedi filmi.", "Ata Demirer",4));
                AddMovie(new Movie(4, "Behzat Ç. Seni Kalbime Gömdüm", "TMC", "Polis başkomiser Behzat Ç'nin hikayesini konu alan bir polisiye filmi.", "Erdal Beşikçioğlu",3));
                AddMovie(new Movie(5, "Babam ve Oğlum", "Sinema Vizyon", "Bir baba ile oğlu arasındaki duygusal bağı anlatan bir dram filmi.", "Çağan Irmak",4));
                AddMovie(new Movie(6, "Kelebeğin Rüyası", "Böcek Film", "Maziye ışık tutan, Türk sinemasının önemli sanatçılarından biri olan Huseyin Rahmi Gürpınar'ın hayatını anlatan bir film.", "Yılmaz Erdoğan",8));
                AddMovie(new Movie(7, "Issız Adam", "Focus Film", "Bir adamın yalnızlığı ve aşkı bulma çabalarını konu alan bir romantik drama filmi.", "Cemal Hünal",7));
                AddMovie(new Movie(8, "Ayla The Daughter of War", "Dijital Sanatlar", "Kore Savaşı'nda Türk askerleri ile bir Koreli kız arasında geçen gerçek bir hikayeye dayanan bir savaş filmi.", "İsmail Hacıoğlu",6));
                AddMovie(new Movie(9, "Neredesin Firuze", "Deli Yapım", "Bir adamın kaybettiği sevgilisini geri kazanmak için giriştiği komik çabalara odaklanan bir romantik komedi filmi.", "Şener Şen",9));
                AddMovie(new Movie(10, "Eyyvah Eyvah 2", "BKM", "Hüsnü'nün İstanbul'da yaşadığı komik olayları konu alan bir devam filmi.", "Ata Demirer",6));
            }

            public List<Movie> GetAllMovie() // tüm filmleri getirir
            {
                return Movies;
            }

            public void AddMovie(Movie movie) // film ekle
            {
                Movies.Add(movie);
            }
        }

    }
}
