namespace WebAPI.Model
{
    public class KelasItem
    {
        private KelasContext context;
        public int id { get; set; }
        public string kelas { get; set; }
        public string jurusan { get; set; }
        public int sub { get; set; }
    }
}
