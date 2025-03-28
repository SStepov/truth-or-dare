using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truth_or_dare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменные:
            bool isOpen = true;
            string command;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Добро пожаловать в игру: Правда или Действие\n");
            Console.ResetColor();

            while (isOpen)
            {
                Console.WriteLine("Вы находитесь в самом гллавном меню!");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступные команды:");
                Console.Write("╔═════════════════\n" +
                              "╠ Начать - ");
                Console.ResetColor();
                Console.WriteLine("перейти в меню выборы");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Информация - ");
                Console.ResetColor();
                Console.WriteLine("информация о игре");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Выход - ");
                Console.ResetColor();
                Console.WriteLine("выйти из игры");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();

                Console.Write("Команда: ");

                Console.ForegroundColor = ConsoleColor.Red;
                command = Console.ReadLine().ToLower();
                Console.ResetColor();

                switch (command)
                {
                    case "начать":
                    case "yfxfnm":

                        Сhoice();

                        break;

                    case "информация":
                    case "byajhvfwbz":

                        Information();

                        break;

                    case "выход":
                    case "ds[jl":

                        Exit();

                        break;

                    default:

                        Error();

                        break;
                }
            }
        }
        static void Сhoice()
        {
            // Переменные:
            bool isOpen = true;
            string command;

            while (isOpen)
            {

                Console.Clear();

                Console.WriteLine("Вы находитесь в выборе режима!");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступные команды:");
                Console.Write("╔═════════════════\n" +
                              "╠ ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Один на один - ");
                Console.ResetColor();
                Console.WriteLine("когда вас только двоя");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Три и больше - ");
                Console.ResetColor();
                Console.WriteLine("когда вас несколько человек");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ Назад - ");
                Console.ResetColor();
                Console.WriteLine("вернуться в главное меню");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Выход - ");
                Console.ResetColor();
                Console.WriteLine("выйти из игры");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();


                Console.Write("Команда: ");

                Console.ForegroundColor = ConsoleColor.Red;
                command = Console.ReadLine().ToLower();
                Console.ResetColor();

                switch (command)
                {
                    case "один на один":
                    case "jlby yf jlby":

                        OneVsOne();

                        break;

                    case "три и больше":
                    case "nhb b ,jkmit":

                        ThreeAndOther();

                        break;

                    case "назад":
                    case "yfpfl":

                        isOpen = false;
                        Console.Clear();

                        break;

                    case "выход":
                    case "ds[jl":

                        Exit();

                        break;

                    default:

                        Error();

                        break;
                }
            }
        }
        static void OneVsOne()
        {
            // Переменные:
            bool isOpen = true;
            string command;
            Random rand = new Random();
            int TruthIndex, DareIndex;


            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine("Вы находитесь в выборе режима!");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступные команды:");
                Console.Write("╔═════════════════\n" +
                              "╠ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Правда - ");
                Console.ResetColor();
                Console.WriteLine("только честность и ничего больше");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Действие - ");
                Console.ResetColor();
                Console.WriteLine("выполни или опозорься");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Назад - ");
                Console.ResetColor();
                Console.WriteLine("выйти из игры");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();

                Console.Write("Команда: ");

                Console.ForegroundColor = ConsoleColor.Red;
                command = Console.ReadLine().ToLower();
                Console.ResetColor();

                switch (command)
                {
                    case "правда":
                    case "ghfdlf":

                        Console.Clear();

                        string[] Dare = new string[]
                        {
                            ("Какая твоя самая нелепая детская мечта?"),
                            ("Ты когда-нибудь влюблялся в друга/подругу?"),
                            ("Опиши самый неловкий момент в твоей жизни."),
                            ("Какая у тебя самая странная привычка?"),
                            ("Ты когда-нибудь подслушивал чужие разговоры? Что услышал?"),
                            ("Какой самый глупый поступок ты совершил из-за симпатии к кому-то?"),
                            ("Ты веришь в привидений? Был ли у тебя «паранормальный» опыт?"),
                            ("Если бы ты мог стереть один день из своей жизни, какой бы это был день?"),
                            ("Ты когда-нибудь плакал из-за фильма/игры? Из-за чего?"),
                            ("Какой самый жуткий комплимент тебе делали?"),
                            ("Ты бы предпочёл всегда говорить правду или всегда лгать (но мастерски выкручиваться)?"),
                            ("Какое самое странное место, где ты засыпал?"),
                            ("Ты когда-нибудь имитировал болезнь, чтобы избежать чего-то?"),
                            ("Какой самый нелепый страх у тебя есть?"),
                            ("Ты бы съел таракана за миллион долларов?"),
                            ("Если бы ты мог узнать абсолютную правду об одном человеке, кого бы выбрал?"),
                            ("Ты когда-нибудь врал о своём возрасте? Зачем?"),
                            ("Какая самая дурацкая вещь, в которую ты верил в детстве?"),
                            ("Ты бы предпочёл никогда не пользоваться интернетом или никогда не выходить из дома?"),
                            ("Какой твой самый постыдный провал в школе/универе?"),
                            ("Ты когда-нибудь писал(а) любовное письмо? Кому?"),
                            ("Если бы ты мог стать невидимкой на день, что бы сделал?"),
                            ("Ты когда-нибудь подглядывал за кем-то?"),
                            ("Какая самая странная вещь, которую ты покупал(а) в интернете?"),
                            ("Если бы ты мог задать один вопрос своему будущему «я», что бы спросил?")
                        };
                        DareIndex = rand.Next(0, Dare.Length);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ваша правда: ");
                        Console.ResetColor();
                        Console.WriteLine(Dare[DareIndex]);
                        Info("Нажмите любую клавишу для продолжения.");
                        Console.ReadKey();

                        break;

                    case "действие":
                    case "ltqcndbt":

                        Console.Clear();

                        string[] Truth = new string[] // Действие
                        {
                            ("Спой песню, которую выберет оппонент, голосом робота."), // 0
                            ("Изобрази эмоцию (злость, восторг, ужас) без слов — пусть другой угадает."), // 1
                            ("Позвони другу/родственнику и скажи: «Я случайно съел твою еду…» (скрин в подтверждение)."), // 2
                            ("Съешь ложку чего-то невкусного (лимон, горчица, соевый соус)."), // 3
                            ("Покажи свою самую нелепую детскую фотографию."), // 4
                            ("Станцуй 30 секунд под музыку, которую включит оппонент."), // 5
                            ("Нарисуй портрет другого игрока… зубами (карандаш в зубы и рисуй)."), // 6
                            ("Напиши в соцсетях статус: «Я сегодня проснулся(ась) и понял(а), что я — ананас»."), // 7
                            ("Издай звук, похожий на динозавра, при следующем чихании."), // 8
                            ("Сними видео, как ты пытаешься лизнуть свой локоть."), // 9
                            ("Поменяйся носками/футболкой с оппонентом на 5 минут."), // 10
                            ("Придумай тост в честь микроволновки и произнеси его с пафосом."), // 11
                            ("Сходи на кухню и вернись с ложкой на носу."), // 12
                            ("Изобрази пантомиму «кошка, застрявшая в дереве»."), // 13
                            ("Спой рэп-импровизацию про этого чата."), // 14
                            ("Сымитируй голосом звук кипящего чайника."), // 15
                            ("Сделай 10 приседаний с серьёзным лицом."), // 16
                            ("Напиши родителю: «Я взломал(а) школьный журнал» (скриншот в чат)."), // 17
                            ("Надень одежду задом наперёд и ходи так 10 минут."), // 18
                            ("Изобрази сцену из «Титаника» с подушкой вместо Кейт Уинслет."), // 19
                            ("Сфоткайся в позе «инстаграм-модели», но максимально нелепо."), // 20
                            ("Произнеси речь в защиту теории плоской Земли (1 минута)."), // 21
                            ("Спрячься в шкаф/под стол на 1 минуту."), // 22
                            ("Съешь что-то с закрытыми глазами, что даст тебе оппонент (безопасно, но невкусно)."), // 23
                            ("Сымитируй голосом персонажа из мультфильма на выбор оппонента.") // 24
                        };
                        TruthIndex = rand.Next(0, Truth.Length);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ваше действие: ");
                        Console.ResetColor();
                        Console.WriteLine(Truth[TruthIndex]);
                        Info("Нажмите любую клавишу для продолжения.");
                        Console.ReadKey();

                        break;

                    case "назад":
                    case "yfpfl":

                        isOpen = false;

                        break;

                    default:

                        Error();

                        break;
                }
            }
        }
        static void ThreeAndOther()
        {
            // Переменные:
            bool isOpen = true;
            string command;
            Random rand = new Random();
            int TruthIndex, DareIndex;


            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine("Вы находитесь в выборе режима!");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Доступные команды:");
                Console.Write("╔═════════════════\n" +
                              "╠ ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Правда - ");
                Console.ResetColor();
                Console.WriteLine("только честность и ничего больше");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Действие - ");
                Console.ResetColor();
                Console.WriteLine("выполни или опозорься");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("╠ ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Назад - ");
                Console.ResetColor();
                Console.WriteLine("выйти из игры");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("╚═════════════════");
                Console.ResetColor();

                Console.Write("Команда: ");

                Console.ForegroundColor = ConsoleColor.Red;
                command = Console.ReadLine().ToLower();
                Console.ResetColor();

                switch (command)
                {
                    case "правда":
                    case "ghfdlf":

                        Console.Clear();

                        string[] Dare = new string[]
                        {
                            ("Станцуй танец маленьких утят, пока остальные подпевают"),
                            ("Изобрази каждого из присутствующих в виде животного (пантомима)"),
                            ("Позвони родителю и скажи, что выиграл(а) конкурс 'Лучший сын/дочь года'"),
                            ("Съешь что-то, что приготовят для тебя другие участники (из безопасных ингредиентов)"),
                            ("Покажи свою самую нелепую детскую фотографию всей компании"),
                            ("Спой песню, которую выберут другие, стоя на стуле как на сцене"),
                            ("Нарисуй портрет самого старшего участника с закрытыми глазами"),
                            ("Напиши в соцсетях пост: 'Я официально объявляю себя королевой/королем этой компании'"),
                            ("Издай самый громкий крик, на который способен"),
                            ("Сними видео, как ты пытаешься достать языком до носа"),
                            ("Поменяйся одной вещью одежды с человеком справа"),
                            ("Придумай и произнеси тост в честь самого младшего участника"),
                            ("Сходи на кухню и вернись с ложкой на носу и вилкой в ухе"),
                            ("Изобрази пантомиму 'обезьяна в зоопарке'"),
                            ("Спой рэп-импровизацию про эту компанию"),
                            ("Сымитируй звук кипящего чайника, мчащегося поезда и сигнализации автомобиля"),
                            ("Сделай 10 приседаний, держа на голове книгу"),
                            ("Напиши любому контакту в телефоне: 'Я съел(а) твое домашнее задание' (покажи всем)"),
                            ("Надень на себя 5 вещей из гардероба других участников"),
                            ("Изобрази сцену из 'Титаника' с двумя другими участниками"),
                            ("Сфоткайся в самой нелепой позе с двумя другими игроками"),
                            ("Произнеси речь в защиту того, что Земля - это плоский блин (1 минута)"),
                            ("Спрячься в шкаф и кричи оттуда загадки, пока тебя не найдут"),
                            ("Съешь что-то с закрытыми глазами, что дадут тебе другие участники"),
                            ("Сымитируй голоса трех известных персонажей по выбору компании")
                        };

                        DareIndex = rand.Next(0, Dare.Length);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ваша правда: ");
                        Console.ResetColor();
                        Console.WriteLine(Dare[DareIndex]);
                        Info("Нажмите любую клавишу для продолжения.");
                        Console.ReadKey();

                        break;

                    case "действие":
                    case "ltqcndbt":

                        Console.Clear();

                        string[] Truth = new string[]
                        {
                            ("Какой самый неловкий момент у тебя был в компании друзей?"),
                            ("Кто из присутствующих тебе больше всех нравится как человек и почему?"),
                            ("Если бы все здесь оказались на необитаемом острове, кого бы ты выбрал(а) в лидеры?"),
                            ("Опиши самого странного человека, с которым тебя сводила судьба"),
                            ("Какая твоя самая постыдная привычка, о которой никто не знает?"),
                            ("Если бы ты мог(ла) поменяться телами с одним из присутствующих на день, кого бы выбрал(а)?"),
                            ("Какое самое глупое прозвище у тебя было в детстве?"),
                            ("Какой самый странный комплимент ты получал(а) от незнакомца?"),
                            ("Если бы все здесь стали персонажами фильма, кто кем был бы?"),
                            ("Какое самое нелепое вранье ты говорил(а), чтобы произвести впечатление?"),
                            ("Кто из знаменитостей тебя разочаровал при личной встрече?"),
                            ("Какой самый странный сон о ком-то из присутствующих тебе снился?"),
                            ("Если бы ты мог(ла) удалить одну песню из истории музыки, что бы это было?"),
                            ("Какое самое неловкое свидание у тебя было?"),
                            ("Какой самый странный предмет ты хранишь у себя дома?"),
                            ("Если бы ты мог(ла) запретить одну вещь для всех в этой комнате, что бы это было?"),
                            ("Какое самое нелепое оправдание ты придумывал(а) для своего опоздания?"),
                            ("Если бы все здесь стали твоими соседями по комнате, кто бы тебя больше всего бесил?"),
                            ("Какой самый странный запрос в поисковике у тебя был?"),
                            ("Если бы ты мог(ла) узнать один секрет о любом из присутствующих, о ком бы ты хотел(а) узнать?"),
                            ("Какое самое неловкое признание в любви ты получал(а)?"),
                            ("Если бы ты мог(ла) отменить одно изобретение человечества, что бы это было?"),
                            ("Какой самый странный подарок ты дарил(а) или получал(а)?"),
                            ("Если бы ты мог(ла) исключить одного человека из этой компании, кто бы это был?"),
                            ("Какое самое нелепое недопонимание у тебя было с кем-то из присутствующих?")
                        };
                        TruthIndex = rand.Next(0, Truth.Length);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Ваше действие: ");
                        Console.ResetColor();
                        Console.WriteLine(Truth[TruthIndex]);
                        Info("Нажмите любую клавишу для продолжения.");
                        Console.ReadKey();

                        break;

                    case "назад":
                    case "yfpfl":

                        isOpen = false;

                        break;

                    default:

                        Error();

                        break;
                }
            }
        }
        static void Error()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Ошибка] ");
            Console.ResetColor();
            Console.WriteLine("Я вас не понял, проверьте пожалуйста ваш ввод.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[Ошибка] ");
            Console.ResetColor();
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться назад.");
            Console.ReadKey();
            Console.Clear();
        }
        static void Info(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n[Информация] ");
            Console.ResetColor();
            Console.WriteLine(text);
        }
        static void Exit()
        {
            Console.ResetColor();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Рады были вас видеть у нас в игре!\n" +
                "Надеюсь вы к нам вернетесь!\n" +
                "Я разработчик Stepov, был рад стараться для вас!");
            Console.ResetColor();
            Environment.Exit(0);

        }

        static void Information()
        {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║          ИНФОРМАЦИЯ ОБ ИГРЕ              ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nО ПРОГРАММЕ:");
                Console.ResetColor();
                Console.WriteLine("Игра 'Правда или Действие' - классическая развлекательная игра");
                Console.WriteLine("для компании друзей. В этой цифровой версии вы можете играть:");
                Console.WriteLine("- один на один (2 игрока)");
                Console.WriteLine("- в компании из 3 и более человек");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nПРАВИЛА ИГРЫ:");
                Console.ResetColor();
                Console.WriteLine("1. Игрок выбирает 'Правда' или 'Действие'");
                Console.WriteLine("2. При выборе 'Правда' - нужно честно ответить на вопрос");
                Console.WriteLine("3. При выборе 'Действие' - нужно выполнить задание");
                Console.WriteLine("4. Можно отказаться от выполнения, но тогда вас ждет наказание!");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nУПРАВЛЕНИЕ:");
                Console.ResetColor();
                Console.WriteLine("- Вводите команды с клавиатуры (как показано в меню)");
                Console.WriteLine("- Можно использовать русскую раскладку или транслитерацию");
                Console.WriteLine("- Для возврата в предыдущее меню используйте команду 'Назад'");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nАВТОР:");
                Console.ResetColor();
                Console.WriteLine("Разработчик: Stepov");
                Console.WriteLine("Версия: 1.0");
                Console.WriteLine("Год: 2025");

                Info("Нажмите любую клавишу для возврата в главное меню...");
                Console.ReadKey();
                Console.Clear();
        }
    }
}