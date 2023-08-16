class ATM
    {
        private List<User> users;
        private User loggedInUser;
        private List<string> transactionLog;

        public ATM()
        {
            users = new List<User>
            {
                new User("user1", "pass123", 1000),
                new User("user2", "pass456", 1500)
            };

            transactionLog = new List<string>();
        }

        public void Start()
        {
            Console.WriteLine("ATM Uygulamasına Hoş Geldiniz!");

            bool isAuthenticated = AuthenticateUser();
            if (!isAuthenticated)
            {
                Console.WriteLine("Geçersiz kullanıcı adı veya şifre. İyi günler!");
                return;
            }

            Console.WriteLine($"Hoş geldiniz, {loggedInUser.Username}!");

            while (true)
            {
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1. Para Çekme");
                Console.WriteLine("2. Para Yatırma");
                Console.WriteLine("3. Bakiye Sorgulama");
                Console.WriteLine("4. Gün Sonu");
                Console.WriteLine("5. Çıkış");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Withdraw();
                        break;
                    case 2:
                        Deposit();
                        break;
                    case 3:
                        CheckBalance();
                        break;
                    case 4:
                        EndOfDay();
                        break;
                    case 5:
                        Console.WriteLine("İyi günler!");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }
            }
        }

        private bool AuthenticateUser()
        {
            Console.Write("Kullanıcı Adı: ");
            string username = Console.ReadLine();

            Console.Write("Şifre: ");
            string password = Console.ReadLine();

            loggedInUser = users.Find(user => user.Username == username && user.Password == password);

            return loggedInUser != null;
        }

        private void Withdraw()
        {
            Console.Write("Çekilecek miktarı girin: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            if (amount > loggedInUser.Balance)
            {
                Console.WriteLine("Yetersiz bakiye.");
            }
            else
            {
                loggedInUser.Balance -= amount;
                Console.WriteLine($"{amount} TL çekildi. Yeni bakiye: {loggedInUser.Balance} TL");

                transactionLog.Add($"[{DateTime.Now}] {loggedInUser.Username} çekme işlemi: -{amount} TL, Yeni bakiye: {loggedInUser.Balance} TL");
            }
        }

        private void Deposit()
        {
            Console.Write("Yatırılacak miktarı girin: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            loggedInUser.Balance += amount;
            Console.WriteLine($"{amount} TL yatırıldı. Yeni bakiye: {loggedInUser.Balance} TL");

            transactionLog.Add($"[{DateTime.Now}] {loggedInUser.Username} yatırma işlemi: +{amount} TL, Yeni bakiye: {loggedInUser.Balance} TL");
        }

        private void CheckBalance()
        {
            Console.WriteLine($"Mevcut bakiye: {loggedInUser.Balance} TL");
        }

        private void EndOfDay()
        {
            string eodFileName = $"EOD_{DateTime.Now:ddMMyyyy}.txt"; //Bugünün tarihini kulanarak dosya adını oluşturuyor

            using (StreamWriter writer = new StreamWriter(eodFileName)) //StreamWriter sınıfını kullanarak dosyaya yazma işlemni başlatıyoruz
            {
                foreach (string logEntry in transactionLog)
                {
                    writer.WriteLine(logEntry);
                }
            }

            Console.WriteLine($"Gün sonu işlem kayıtları {eodFileName} adlı dosyaya kaydedildi.");
        }
    }