namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootUser = "root";
            string rootUserPwd = "toor";
            string usuariPwdIntroduit = null;
            string usuariIntroduit = null;
            int numeroAtt = 2;

            while ((usuariIntroduit == null) || (usuariIntroduit == "") || (usuariIntroduit != rootUser && usuariPwdIntroduit != rootUserPwd))
            {
                Console.Clear();
                Console.WriteLine("Ubuntu 16.04 LTSS ubuntu tty1");
                Console.Write("ubuntu login: ");
                usuariIntroduit = Console.ReadLine();
                Console.Write("User pwd: ");
                usuariPwdIntroduit = Console.ReadLine();

                if (usuariIntroduit == "")
                {
                    numeroAtt--;
                    Console.WriteLine("introdueix un usuari");
                    Console.WriteLine("intents restants " + numeroAtt);
                    if (numeroAtt != 0) Console.WriteLine("presiona enter per a tornar a intentar");
                    else if (numeroAtt == 0) Console.WriteLine("presiona enter per finalitzar, ja no queden mes intents");
                    Console.ReadLine();
                }
                
                if (usuariIntroduit != rootUser && usuariPwdIntroduit != rootUserPwd)
                {
                    numeroAtt--;
                    Console.WriteLine("introdueix una contrasenya valida per al usuari root o usuari root valid");
                    Console.WriteLine("intents restants " + numeroAtt);
                    if (numeroAtt != 0) Console.WriteLine("presiona enter per a tornar a intentar");
                    else if (numeroAtt == 0) Console.WriteLine("presiona enter per finalitzar, ja no queden mes intents");
                    Console.ReadLine();
                }

                if (numeroAtt == 0) break;
            }

            if (usuariPwdIntroduit == rootUserPwd && usuariIntroduit == rootUser)
            {
                Console.Clear();
                Console.WriteLine("Ubuntu 16.04 LTSS ubntu tty1");
                Console.WriteLine("benvingut root!");
            }
            else
            {
                Console.WriteLine("has utilitzat el maxim d'intents per iniciar sesió");
            }
        }
    }
}