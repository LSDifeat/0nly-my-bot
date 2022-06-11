using System;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;

namespace discord_bot
{
    class Program
    {
        DiscordSocketClient client;

        static void Main(string[] args)
          => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            client = new DiscordSocketClient();
            client.MessageReceived += CommandsHandler;
            client.Log += Log;
            
            var token = "OTg0ODM3MzEzMDY0NDkzMDY3.GaaJFp.kbONl9x3ZCRJy-w_RPgtZ9g2x6MVmP4jhUS7FE";


                await client.LoginAsync(TokenType.Bot, token);
                await client.StartAsync();

                
        }

        private Task Log(LogMessage msg)
        {
           
            return Task.CompletedTask;
        }

        private Task CommandsHandler(SocketMessage msg)
        {
            if (!msg.Author.IsBot);
           switch(msg.Content)
            {
                case "!привет":
                    {
                        msg.Channel.SendMessageAsync($"пошел нахуй");
                    break;
                    }

                case "!как дела":
                    {
                        msg.Channel.SendMessageAsync($"нармальна даб даб даб");
                        break;
                    }

                case "!что ты умеешь":
                    {
                        msg.Channel.SendMessageAsync($"дать тебе хуем по лбу могу");
                        break;
                    }

                case "!пока":
                    {
                        msg.Channel.SendMessageAsync($"хуем по лбу на");
                        break;
                    }

                case "!ало":
                    {
                        msg.Channel.SendMessageAsync($"хуем по лбу не дало?");
                        break;
                    }
                case "!ты кто":
                    {
                        msg.Channel.SendMessageAsync($"хто, я?");
                        break;
                    }

                case "!да ты":
                    {
                        msg.Channel.SendMessageAsync($"хто я пидор? а может быть ты?");
                        break;
                    }

                case "!крол":
                    {
                        msg.Channel.SendMessageAsync($"я пожилой крол даб даб");
                        break;
                    }

                case "!пидор":
                    {
                        msg.Channel.SendMessageAsync($"че ты там пукаешь, я не понял");
                        break;
                    }

                case "!сука":
                    {
                        msg.Channel.SendMessageAsync($"че ты там высрал, я не понял");
                        break;
                    }

                case "!что ты осуждаешь":
                    {
                        msg.Channel.SendMessageAsync($"я осуждаю слово на Н, слово на П, я это осуждаю, я это не одобряю");
                        break;
                    }

                case "!человек":
                    {
                        msg.Channel.SendMessageAsync($"НИХУЯ СЕБЕ, ДА ПОШЕЛ ТЫ НАХУЙ!!!!!");
                        break;
                    }

                case "!ку":
                    {
                        msg.Channel.SendMessageAsync($"ты кто?");
                        break;
                    }

                case "!я человек":
                    {
                        msg.Channel.SendMessageAsync($"НИХУЯ СЕБЕ, ДА ПОШЕЛ ТЫ НАХУЙ!!!!!");
                        break;
                    }
                case "!зачитай рэпчик":
                    {
                        msg.Channel.SendMessageAsync($"опа нихуева зигота заебись пенелопа ебать тупа расколбасик получаю я ебаться тупа заебаться с телками бухаем отдыхаем нихуя себе ебать тупа тупа поебать тупа тупа нихуевая басуха лупит по моим ушам опа опа анденбам опа нихуя лиза лизаве ебать ушам лиши меня девственности нихуясе да нахуй ты нужна проститутка ебаная я люблю дрочить я люблю дрочить я люблю дрочить мне поебать на тебя я дрочу день ото дня нихуя и поебать на тебя доставаю свой елдон тупа тупа не пиздон нихуя себе лупендит охуенная музяка заебака нихуяка пизда тупа кикандос и кикинда нихуева заебата нихуя себе пиздец охуенный бля конец я ебался бля в ебать опа нихуя заебенная хуйня заебися охаися нихуя себе пизда о опа нихуева бля лупендит ебашит ебашит ебашит ебашит ебашит ебашит ебашит ебашит ебабабабабаааааа ... на балкон постремить ... нихуя себе лупендит охуенная бассуха лупит в моё ухо я ягуляю тупа раскалбас получаю тёлка улыбается мне похуй заебца опца дритца оп цаца нихуя себе ебать ... тьфу блять нихуева заебца опца дритца оп цаца нихуева заебца лупендит бассуха бассуха бассуха нет бассуха ебашит я тупа получаю расколбасик нихуева заебаться в рот ебаться нихуя себе ебашить тупа заебись нахуй расколб нах тупа атдихаю тупа зажигаю нихуева бля ебашить тупа бассуха в мое пожилое ухо нихуя себе ебать заебаться не въебаться аааааа тьфу блять да иди ты нахуй");
                        break;
                    }

                case "!саня":
                    {
                        msg.Channel.SendMessageAsync($"саня хуй соси");
                        break;
                    }

                case "!фоксус":
                    {
                        msg.Channel.SendMessageAsync($"хуексус, не знаю такого пидора");
                        break;
                    }

                case "!зачитай репчик":
                    {
                        msg.Channel.SendMessageAsync($"ииихххапхапхап пошел нахуй попущеный!");
                        break;
                    }

                case "!зачем ты нужен":
                    {
                        msg.Channel.SendMessageAsync($"мать твою ебать");
                        break;
                    }


                case "!когда релиз":
                    {
                        msg.Channel.SendMessageAsync($"не ебу");
                        break;
                    }

                case "!где":
                    {
                        msg.Channel.SendMessageAsync($"в пизде");
                        break;
                    }



                case "!ты натурал?":
                    {
                        msg.Channel.SendMessageAsync($"я гэй я ебался в жопу");
                        break;
                    }


                case "!еблан":
                    {
                        msg.Channel.SendMessageAsync($"ну как пошуми девочка фристайл, слушай рэп пажилова челавека");
                        break;
                    }


                case "!дарова":
                    {
                        msg.Channel.SendMessageAsync($"А я тебя сука найду, и тебе сломаю пизду ебаная блядь, ты попущен давно уже сука, ебаный ты пидор ты блядь, ебать ты меня понял?!");
                        break;
                    }


                case "!соси хуй":
                    {
                        msg.Channel.SendMessageAsync($"соси ты мой пожилой полувялый хуй");
                        break;
                    }


                case "!мусор":
                    {
                        msg.Channel.SendMessageAsync($"мусара, хто такие мусара");
                        break;
                    }


                case "!разработка?":
                    {
                        msg.Channel.SendMessageAsync($"пошел нахуй я не шарю");
                        break;
                    }



                case "!как разработка?":
                    {
                        msg.Channel.SendMessageAsync($"пошел нахуй я не шарю");
                        break;
                    }
                case "!хай":
                    {
                        msg.Channel.SendMessageAsync($"я пожилой крол даб даб даб");
                        break;
                    }

                case "!да":
                    {
                        msg.Channel.SendMessageAsync($"пизда");
                        break;
                    }

                case "!нет":
                    {
                        msg.Channel.SendMessageAsync($"пидора ответ");
                        break;
                    }

                case "!аргумент не нужен, пидор обнаружен":
                    {
                        msg.Channel.SendMessageAsync($"сыну шлюхи слова не давали");
                        break;
                    }

                case "!милицай":
                    {
                        msg.Channel.SendMessageAsync($"ну тварь пизда");
                        break;
                    }

























































            }
                
                
                
                return Task.CompletedTask;
        }
    }
}
