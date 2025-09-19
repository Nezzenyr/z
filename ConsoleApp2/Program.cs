namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            /*

             int käimasolevAasta = 2025;
             int olenNiiVana = 17;
             int Tulemus = käimasolevAasta + olenNiiVana;

             //float pikkus = 2.5f;

             string sõnum = "Teie vanus on: ";


             //bool miskion = false;



             //Console.WriteLine(sõnum + Tulemus);
             //    Console.WriteLine("sõnum");
             //    Console.WriteLine("sõnum");
             //    Console.WriteLine("sõnum");
             //    Console.WriteLine("oioioioioi");
             //    Console.WriteLine("sõnum");
             //    Console.WriteLine("sõnum"");

             */













            //int arv1 = 0;
            //int arv2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene arv");
            //arv1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta teine arv");
            //arv2 = int.Parse(Console.ReadLine());
            //int liitmine = arv1 + arv2;
            //Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - * /");
            //string tehtetüüp = Console.ReadLine();
            //int tehe = 0;

            //if (tehtetüüp == "+"  /*tingimus siia*/)
            //{
            //    tehe = arv1 + arv2;
            //}




            //if (tehtetüüp == "-"    /*tingimus siia*/)
            //{
            //    tehe = arv1 - arv2;
            //}




            //if (tehtetüüp == "*"   /*tingimus siia*/)
            //{
            //    tehe = arv1 * arv2;
            //}




            //if (tehtetüüp == "/"   /*tingimus siia*/)
            // {
            //    tehe = arv1 / arv2;
            //}





            //Console.WriteLine($" {tehtetüüp} Tehte tulemus: {tehe}");


            //  int arv3 = 0;
            //  int arv4 = 0;
            //  Console.WriteLine("Tere, palun sisesta esimene lahutav");
            //  arv3 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Tere, palun sisesta teine lahutav");
            //  arv4 = int.Parse(Console.ReadLine());
            //  int lahutamine = arv3 - arv4;
            //  Console.WriteLine($"Tehte tulemus: {lahutamine}");
            //  Console.WriteLine("Tehte tulemus: " + lahutamine);

            //  int arv5 = 0;
            //  int arv6 = 0;
            //  Console.WriteLine("Tere, palun sisesta esimene korrutav");
            //  arv5 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Tere, palun sisesta teine korrutav");
            //  arv6 = int.Parse(Console.ReadLine());
            //  int korrutamine = arv5 * arv6;
            //  Console.WriteLine($"Tehte tulemus: {korrutamine}");
            //  Console.WriteLine("Tehte tulemus: " + korrutamine);

            //  int arv7 = 0;
            //  int arv8 = 0;
            //  Console.WriteLine("Tere, palun sisesta esimene jagaja");
            //  arv7 = int.Parse(Console.ReadLine());
            //  Console.WriteLine("Tere, palun sisesta teine jagaja");
            //  arv8 = int.Parse(Console.ReadLine());
            //  int jagamine = arv7 / arv8;
            //  Console.WriteLine($"Tehte tulemus: {jagamine}");
            //  Console.WriteLine("Tehte tulemus: " + jagamine);

            // + liitmine
            // - lahutamine
            // / jagamine
            // * korrutamine
            string lemmikpuuvili = "";
            string valik = "";
            string lemmikjuurvili = "Jah";
            Console.WriteLine("Kas sulle meeldivad juurviljad või puuviljad?");
            valik = Console.ReadLine();

            if (valik == "puuviljad")
            {
                Console.WriteLine("Missugune puuvili sulle meeldib?");

                lemmikpuuvili = Console.ReadLine();



                if (lemmikpuuvili == "maasikas")
                {
                    Console.WriteLine("Maasikas ei ole puuvili");
                }
                else if (lemmikpuuvili == "pirn")
                {
                    Console.WriteLine("Kas magus pirn või hapu pirn, mõlemad on head");
                }
                else if (lemmikpuuvili == "kartul")
                {
                    Console.WriteLine("See ei kasva isegi mitte puu otsas");
                }
                else
                {
                    Console.WriteLine("Ei tunne seda puuvilja");
                }
            }

            else if (valik == "juurviljad")
            {
                Console.WriteLine("Missugune juurvili sulle meeldib?");


                lemmikjuurvili = Console.ReadLine();

                if (lemmikjuurvili == "maasikas")
                {
                    Console.WriteLine("Maasikas ei ole juurvili");
                }
                else if (lemmikjuurvili == "pirn")
                {
                    Console.WriteLine("Pirn ei ole juurvili");
                }
                else if (lemmikjuurvili == "kartul")
                {
                    Console.WriteLine("Kartulid meeldivad mulle ka");
                }

            }else
            {
                Console.WriteLine("Seda valikut ei ole");
            }
        }
    }
}