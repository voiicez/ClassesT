namespace ClassesT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci ogrenci = new Ogrenci(); Not a best way to do it 1
            Student student = new Student();
            student.SetId(4);
            student.SetName("Behlül");
            student.Surname = "Şahin"; //property kullandık.
            Console.WriteLine(student.GetId()+" "+student.GetName()+" "+student.Surname);
            
            
        }

    }

    //class Ogrenci Not a best way to do it 1
    //{
    //    public int id;
    //    public string adi;
    //    public string soyadi; //bunların her biri field, alan.
    //}

    class Student //Alanları public yapmayalım. "Id" karışmasın diye _id yazalım ilkine.
    {
        int _id; //id olduğu durumda this kullanılacak.
        string _adi;
        public void SetId(int id) //davranış, behavior.
        {
            _id = id; //veya this.id=id; de olurdu.
        }

        public int GetId() 
        {
            return _id;
        }
        public void SetName(string adi)
        {
            _adi = adi;
        }

        public string GetName()
        {
            return _adi;
        }

        public string Surname { get; set; } //Otomatik get ve set yapar. özellik,property
    }
}