using System;

namespace Tutorial_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Title = "Jim Crow Interactive Decision Program";
           //("Jim Crow Interactive Decision Program");

            string name, breakfast, scene1, scene2, scene3, scene4, scene5, scene6, scene0, scene8, scene9;
            double scenecontroller = 1, scene7;
            breakfast = "beans";

            Console.WriteLine("      Welcome to the Jim Crow Era interactive decision program. This program is designed to teach you about the Jim Crow Era through a series of choices. To choose something just type the number next to the response you choose. Hitting enterwill advance the scenes. Please provide your first and last name below.");
            Console.WriteLine(" ");
            name = Console.ReadLine();
            Console.WriteLine(" ");

            if (name == "Eric Foner"  || name == "eric foner") {
                Console.WriteLine("      Hello Mr. Foner, thank you for taking the time to come to our school to help us in our understanding of history, we hope you enjoy this interactive experience!");
                Console.ReadLine();
                //Console.WriteLine(" ");
            }

            Console.WriteLine("      You wake up on a brisk fall morning in Chicago, Illinois, ready for another day of work. The date is July 27th,   1919.");
            Console.WriteLine("      The dull sounds of the city seep into your apartment, where you live with your wife and three children. You briskly get up to start off the day. There is little room to idle."); //Intro
            Console.ReadLine();

            while(scenecontroller == 1){

                Console.WriteLine("      As you wake up you need to decide what to have for breakfast. You can either stay home and eat the standard, somewhat bland porridge, or you can take the risk of eating at the diner."); //Scene 1
                Console.WriteLine();
                Console.WriteLine("      Which do you choose?");
                Console.WriteLine("      1. Stay at home"); // 1a
                Console.WriteLine("      2. Go to the diner"); // 1b
                Console.WriteLine("");
                scene1 = Console.ReadLine();
                Console.WriteLine();

                if (scene1 == "1") {

                    Console.WriteLine("      You remain at home and eat the porridge. As you swallow down the last few spoonfuls, you're glad that you avoided the anxiety and pressure that comes from going out."); //Result 1a
                    Console.ReadLine();
                    breakfast = "eating porridge";
                    scenecontroller = 3;
                    break;

                }
                if (scene1 == "2") {

                    Console.WriteLine("      You walk down the block to the diner to get something to eat. You keep your head down, walk on the 'colored' side of the pavement, and try to swallow your nervousness."); //Result 1b
                    Console.ReadLine();
                    scenecontroller = 2;
                    break;

                }
                else {
                    Console.WriteLine("      That's not a valid response, please try again."); //Error
                    Console.WriteLine(" ");
                }
            }
            while (scenecontroller == 2) {
                
                Console.WriteLine("      You arrive at the diner and sit in a partitioned-off booth in the far corner. You decide to order a plate of eggs and wait for the food to be served. A few minutes later, a white man enters the diner and sits in a nearby stall. He orders the same plate of eggs. You continue patiently waiting, until the server comes out and delivers the white man his meal before you. You feel cheated. There was no reason he should have received his food before you, but he did."); //Scene 2
                Console.WriteLine();
                Console.WriteLine("      What do you do?");
                Console.WriteLine("      1. Take no action");
                Console.WriteLine("      2. Talk to the server");
                Console.WriteLine();
                scene2 = Console.ReadLine();

                 if (scene2 == "1") {

                    Console.WriteLine();
                    Console.WriteLine("      You decide to simply wait it out. You’re disgruntled with the diner and feel slighted, but take no action. Another fifteen minutes pass, and you finally receive your food. You eat the meal undisturbed, pay the bill, and leave the diner.");
                    Console.WriteLine("      During the Jim Crow Era if whites and blacks ate together the white was supposed to get served first.");
                    Console.ReadLine();
                    breakfast = "eating at the diner";
                    scenecontroller = 3;

                }
                if (scene2 == "2") {

                    Console.WriteLine();
                    Console.WriteLine("      You decide to speak out about your situation. You walk about to the white server and ask him why the other man hadbeen served before you. Even with your respectful tone, the server and the diner’s manager are offended that you would “accuse” them of making a mistake. You are forced to leave the restaurant without food before things become any more heated.");
                    Console.WriteLine("      During the Jim Crow Era if whites and blacks ate together the white was supposed to get served first. If there wasa complaint they wouldn’t listen to the black person even if they were right to complain. It wouldn’t be uncommon for them to get kicked out for this type of complaint.");
                    Console.ReadLine();
                    breakfast = "getting kicked out of the diner";
                    scenecontroller = 3;

                }
                else {

                    Console.WriteLine("      That's not a valid response, please try again."); //Error
                    Console.WriteLine(" ");

                }
            }   
            while(scenecontroller == 3){

                Console.WriteLine("      After " + breakfast + " you need to quickly get to work. You can either take the bus or walk."); //Scene 3
                Console.WriteLine();
                Console.WriteLine("      Which do you choose?");
                Console.WriteLine("      1. Ride the bus");
                Console.WriteLine("      2. Walk to work");
                Console.WriteLine();
                scene3 = Console.ReadLine();
                Console.WriteLine();

                if (scene3 == "1") {

                    Console.WriteLine("      Riding the bus seems much faster. You stroll over to the closest bus stop and get on.");
                    Console.ReadLine();
                    scenecontroller = 4;
                    break;

                }
                if (scene3 == "2") {

                    Console.WriteLine("      You know that walking to work will take longer, but can sometimes be much safer. By walking, you avoid the heavy discrimination you would face on public transportation.");
                    Console.WriteLine("      Walking is safer because of the common descrimination that would appear on a bus, mainly because it was a scenario where both races were forced into a confined space.");
                    Console.ReadLine();
                    scenecontroller = 6;
                    break;

                }
                else {

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" ");

                }
            }
            while (scenecontroller == 4){

                Console.WriteLine("      Once you get on the bus you have a few options for seating. Where do you decide to sit?"); //Scene 4
                Console.WriteLine("      1. At the front of the bus");
                Console.WriteLine("      2. At the back of the bus");
                scene4 = Console.ReadLine();

                if (scene4 == "1"){

                    Console.WriteLine("      Feeling confident, you decide to sit at the front of the bus. You feel the glares of the nearby white passengers but youtry not to let it bother you.");
                    Console.WriteLine("      Sitting in the front of the bus would be unheard of mainly because laws during this time would prohibit a front seat being given to a black person.");
                    Console.ReadLine();
                    scenecontroller = 5;
                    break;

                }
                if (scene4 == "2"){

                    Console.WriteLine("      You decide that it is safer to sit in the back of the bus, specifically in the seats designated for people of color. Later during the ride you n otice a white lady get on the bus and sit in the front seat you had conteplated earlier. You are relieved that you avoid the altercation, but are still irked by the blatant discrimination.");
                    Console.WriteLine("      Sitting in the back was a safer bet then sitting in the front because it was a better seat and if a white person wanted the seat that you were in, they would get it.");
                    Console.ReadLine();
                    scenecontroller = 7;
                    break;

                }
                else{

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" "); 

                }

            }
            while (scenecontroller == 5){

                Console.WriteLine("      A few minutes later, a white woman gets on the bus. The nearby seats are full and she approaches your seat, staring expectantly."); //Scene 5
                Console.WriteLine();
                Console.WriteLine("      What should you do?");
                Console.WriteLine("      1. Offer her the seat next to you and start some friendly small talk.");
                Console.WriteLine("      2. Give up your seat and walk to the back of the bus without complaint.");
                Console.WriteLine("      3. Remain in your seat and avoid eye contact.");
                scene5 = Console.ReadLine();

                if (scene5 == "1") {

                    Console.WriteLine("      You shift over to the adjacent seat to make room for the lady. You politely ask her name and where she is headed. The white bus driver is appalled, even more so than the lady, and yells at you for your behavior. You are kicked off the bus and forced to walk the rest of the distance to work.");
                    Console.WriteLine("      To white people back then the idea that a black person would not give them what they wanted or would even start talking to them was incoceivable. Even if you did all this nicely and politely.");
                    Console.ReadLine();
                    scenecontroller = 6.5;
                    break;

                }
                if (scene5 == "2") {

                    Console.WriteLine("      You feel terrible as you reluctantly stand up to let the lady sit in your seat. You walk with your head down past the other white passengers to take a spot at the back of the bus. You're mocked by the other passengers but are forced to say nothing.");
                    Console.WriteLine("      White people always got what they wanted, sometimes it was even required by law like instances on the bus where black people were supposed to sit in the back, separate didn't always include the equal.");
                    Console.ReadLine();
                    scenecontroller = 7;
                    break;

                }
                if (scene5 == "3") {

                    Console.WriteLine("      The lady does not take up an empty seat at the back of the bus. Instead, she continues to look at you without saying a word. She clearly wants you to get up, but you refuse to move. The bus driver notices and yells at you to give her the seat. You reluctantly get up and walk to the back of the bus with your head down.");
                    Console.WriteLine("      White peole always got what they wanted, sometimes it was even required by law like instances on the bus where black people were supposed to sit in the back, separate didn't always include the equal.");
                    Console.ReadLine();
                    scenecontroller = 7;
                    break;

                }
                else {

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" "); 

                }
            }
            while (scenecontroller == 6) {

                Console.WriteLine("      As you start walking to work you see two white guys walking teh opposite direction, one in a white shirt and the other in a blue hat. You look down and try not to make eye contact but they push you to the ground anyways.");//Scene 6
                Console.WriteLine();
                Console.WriteLine("      How do you react?");
                Console.WriteLine("      1. Get up and hit back");
                Console.WriteLine("      2. Stay down until they leave");
                scene6 = Console.ReadLine();

                if (scene6 == "1") {

                    Console.WriteLine("      You decide to get back up and punch the guy in the white shirt. A little fight breaks out and a police officer comes over to break it up. He takes you away for misconduct, but leaves the white guys claiming that 'they didn't do nothing.'");
                    Console.ReadLine();
                    scenecontroller = 0.1;
                    break;

                }
                if (scene6 == "2"){

                    Console.WriteLine("      You lay there in the dirt until they leave, as they walk away they laugh in mocking and you get up to brush off the dirt. you continue on your way to work a little dirty and discouraged.");
                    Console.ReadLine();
                    scenecontroller = 7;
                    break;

                }
                else {

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" "); 

                }
            }
            while (scenecontroller == 6.5) {

                Console.WriteLine("      As you start walking to work you see two white guys walking the opposite direction, one in a white shirt and the other in a blue hat. They saw you talking to the lady on the bus and trip you for 'daring to talk to a fine lady like her.'");//Scene 6.5
                Console.WriteLine();
                Console.WriteLine("      How do you react?");
                Console.WriteLine("      1. Get up and hit back");
                Console.WriteLine("      2. Stay down until they leave");
                scene0 = Console.ReadLine();

                if (scene0 == "1") {

                    Console.WriteLine("      You decide to get up and punch the guy in the white shirt. A little fight breaks out and a police officer comes over to break it up. He takes you away for misconduct, but leaves the white guys alone to 'clean up the mess.'");
                    Console.ReadLine();
                    scenecontroller = 0.2;
                    break;

                }
                if (scene0 == "2") {

                    Console.WriteLine("      You lay there in the dirt until they leave, as they walk away they laugh in mocking and you get up to brush off the dirt. You continue on your way to work a little dirty and discouraged.");
                    Console.ReadLine();
                    scenecontroller = 7;
                    break;

                }
                else {

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" "); 

                }

            }
            while (scenecontroller == 7) {

                Console.WriteLine("      You finally arrive at work. As usual, your boss is sitting in his office and you wearily approach him to clock in. you knock on the large oak door, once, then twice. 'Come in!' shouts a husky voice from inside. You open the door, but still remain outside the office. 'Oh, you.' He briefly chuckles. 'How long you workin' today? And don't lowball me again, I want to see some progress.'");//Scene 7
                Console.WriteLine("      How many hours do you work for?");
                scene7 = Convert.ToDouble(Console.ReadLine());

                if (scene7 < 10) {

                    Console.WriteLine("      Absolutely, not! I will not have an employee underneath me do a disservice to my business. In fact, why don't you work 12 hours today. That'll teach ya' a lesson");
                    Console.WriteLine("      You work a brutal 12 hour shift. Exhausted physically and mentally, you dismiss yourself from work and begin walking home.");
                    Console.ReadLine();
                    scenecontroller = 8;
                    break;

                }
                if (scene7 >= 10 && scene7 <= 12) {

                    Console.WriteLine("      Hmm... you're on thin ice fella but I'll let you go this time if it's a quality " + scene7 + " hours.");
                    Console.WriteLine("      You work a strenuous but standard "+ scene7 +" hour shift. Feeling optimistic, you dismiss yourself from work and begin walking home.");
                    Console.ReadLine();
                    scenecontroller = 8;
                    break;

                }
                if (scene7 > 12) {

                    Console.WriteLine("      Now that's a hard working employee! Just for that, I'll let you off with an earlier shift. How does 12 hours sound?");
                    Console.WriteLine("      You work a brutal 12 hour shift, wondering why you had asked for something even longer. Exhausted physically and mentally, you dismiss yourself from work after twelve hours and begin walking home.");
                    Console.ReadLine();
                    scenecontroller = 8;
                    break;

                }
                 else {

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" "); 

                }

            }
            while (scenecontroller == 8) {

                Console.WriteLine("      On your journey back home, you hear faint shouting in the distance. Intrigued, you approach the sounds and find an angry mob of Black protestors. It appeared that a secenteen-year-old African-American by the name of Eugene Williams had been on a rafting trip with some friends. they had mistakenly crossed the invisible line into 'white terrirory' and a white man named George Stauber had responded by throwing large stones at the youth. In the chaos Eugene had fallen off the raft and drowned. The protestors seeked justice for the boy and demanded Mr. Stauber be arrested.");//Scene 8
                Console.WriteLine();
                Console.WriteLine("      What do you do?");
                Console.WriteLine("      1. Join the riot");
                Console.WriteLine("      2. Leave the scene and return home");
                scene8 = Console.ReadLine();

                if (scene8 == "1") {

                    Console.WriteLine("      Filled with a newfound desire to support your people, you join the riot.");
                    Console.ReadLine();
                    scenecontroller = 9;
                    break;

                }
                if (scene8 == "2") {

                    Console.WriteLine("      Hesitant about the outcome of the riot, you flee the scene to go home.");
                    Console.ReadLine();
                    scenecontroller = 10;
                    break;

                }
                else {

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" "); 

                }

            }
            while (scenecontroller == 9) {

                Console.WriteLine("      The riot begins with shouting and jeering but quickly picks up pace. things start gettin heated, and the crowd is sent into a mad frenzy. People are throwing stones, damaging property and getting violent enough to get the police to take notice. But instead of arresting the white man involved in the death, the officer decides to arrest a protesting black man.");//Scene 9
                Console.WriteLine();
                Console.WriteLine("      Given the circumstances, what do you choose to do?");
                Console.WriteLine("      1. Rush to the front of the crowd and engage in the protest as much as possible.");
                Console.WriteLine("      2. Remain in the middle of the crowd, and continue shouting with everyone else");
                Console.WriteLine("      3. Leave the riot");
                scene9 = Console.ReadLine();

                if (scene9 == "1") {

                    Console.WriteLine("      You shove your way to the front of the crowd and, to your horror, you see the white police force prepared for armed conflict. A series of actions and retaliations become increasingly violent and the police begin forcefully arresting rioters. As one of the leading activists, you are arrested as well.");
                    Console.ReadLine();
                    scenecontroller = 0.3;
                    break;

                }
                if (scene9 == "2") {

                    Console.WriteLine("      The police arrive on scene in an attempt to suppress the riot. A series of minor conflicts leads to increasing violent escalations and the relatively harmless protest transitions into bloody mayhem. You escape from the scene by slipping away through the back of the crowd.");
                    Console.ReadLine();
                    scenecontroller = 11;
                    break;

                }
                if (scene9 == "3") {

                    Console.WriteLine("      Hesitant about the outcome of the riot you retreat from the scene to go home.");
                    Console.ReadLine();
                    scenecontroller = 10;
                    break;

                }
                else {

                    Console.WriteLine("      That's not a valid response, please try again.");
                    Console.WriteLine(" "); 

                }

            }
            while (scenecontroller == 10) {

                Console.WriteLine("      You return to your family in the evening. Many of the homes in your local community are empty, likely participating in the riot. You begin feeling very conflicted. On one hand, you and your family are safe from the oppressive hands of white policemen however, you wonder if you should have stayed at the riot to support your people. After all, change will not come without a push. Are you doing a disservice by staying home? To what extent do you risk your own life and your family's safery for a glimpse of true freedom? These seemingly impossible questions fill your mind as you hear the sounds of the riot in the distance.;");//Ending 1
                Console.ReadLine();
                scenecontroller = 12;
                break;

            }
            while (scenecontroller == 11) {

                Console.WriteLine("      Unscathed, you return home to your family. You notice that some other men have also left the riot but many of your neighbor's homes remain empty. Any feelings of shame for leaving immediately disappear when you find that your family is safe at home. What a day.");
                Console.ReadLine();
                Console.WriteLine("      The following morning you pick up a local newspaper on the way to work, specifically looking for information about the riot. You even skim through page after page with no reference to the event. Then, on the final page, a breif article no greater than a hundred words summarizes the conflict. It seems that just a minor scuffle had taken place in the city due to the rowdy behavior of some Black individuals. You feel terrible seeing the misrepresented news, but this is nothing new. Such falsified reports were publiched nearly every day. By downplaying the evens, the oppressive governments could claim that no change was necessary. A bit frustreated, but not disheartened, you continue on your way.");//Ending 2
                Console.ReadLine();
                scenecontroller = 12;
                break;

            }
            while (scenecontroller == 0.1) {

                Console.WriteLine("      You get taken away by the police officer and taken to jail. When you get there you ask him why he didn't take the white guys who started teh fight. He responds with 'You really think I would take those fine gentlemen when you fold start all the fights in this town?' You sit down to that and wonder why the law can't protect those it's supposed to. You start to cry as you think of the life you will have to live in jail because of the Jim Crow laws and the unfairness this is going to create for generations to come.");//Jail 1
                Console.ReadLine();
                scenecontroller = 12;
                break;

            }
            while (scenecontroller == 0.2) {

                Console.WriteLine("      You get taken away by the police officer and taken to jail. When you get there you ask him why he didn't take the white guys who started the fight. He answers you with 'They were only trying to defend poor Miss. Sally from being attacked by rapscallions like you! Why would I ever arrest them?' he chuckles as he thinks about the idea of arresting those white folk. 'Now sit down and think about what you've done.' He commands. As you sit you realize something important, African-Americans are gonna get treated poorly and always will be treated poorly. You start to cry as you wonder how it will ever be equal if it's separate.");//Jail 2
                Console.ReadLine();
                scenecontroller = 12;
                break;

            }
            while (scenecontroller == 0.3) {

                Console.WriteLine("      After getting arrested you get taken to jail. When you get there you are surrounded by other African-Americans who were protesting like you. When asked about why Mr. Strauber’s death has gone unnoticed the police officer's reply ‘He was the one who crossed the line, shouldn’t have crossed it.’ You start to cry as you remember the many who have died and never received justice. The impact this failure of a reconstruction will make on the future is massive. The efforts of you and your brethren will go unnoticed tomorrow morning and nothing will be different as always.");//Jail 3
                Console.ReadLine();
                scenecontroller = 12;
                break;

            }
            while (scenecontroller == 12) {

                Console.WriteLine("      Thank you so much for going through this expierience, we hope that you were able to learn more about the expierience of African-Americans during the Jim Crow Era and the effect it's had on us today.");
                Console.ReadLine();
                System.Environment.Exit(1);

            }
            Console.ReadLine();
        }
    }
}
