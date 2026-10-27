// - 1
string topic = "C#";
int planned = 40;
double distance = 1.5;
decimal rate = 12.50m;
char code = 'B';
bool completed = false;
long bytes = 5000000000;

Console.WriteLine($"Topic: {topic}");
Console.WriteLine($"Planned: {planned}");
Console.WriteLine($"Distance: {distance}");
Console.WriteLine($"Rate: {rate}");
Console.WriteLine($"Code: {code}");
Console.WriteLine($"Completed: {completed}");
Console.WriteLine($"Bytes: {bytes}");
Console.WriteLine("===================================================");

// - 2
const int minutesPerHour = 60;
var sessionCount = 3;

var minutes = 20;
var actualMinutes = minutes;
actualMinutes = 25;

var totalMinutes = actualMinutes + (minutesPerHour * sessionCount);

var copiedMinutes = actualMinutes;
copiedMinutes = 30;

var copyTopic = topic;
copyTopic = "SQL";

Console.WriteLine($"Actual: {actualMinutes}");
Console.WriteLine($"Total Minutes: {totalMinutes}");
Console.WriteLine($"Minutes Original/Copy: {actualMinutes}/{copiedMinutes}");
Console.WriteLine($"Topic Original/Copy: {topic}/{copyTopic}");
Console.WriteLine("===================================================");

// - 3

int add = 18 + 7;
int subtract = 18 - 7;
int multiply = 18 * 7;
int divide = 18 / 7;
int modulus = 18 % 7;
double divideDouble = 18.0 / 4.0;
var result = 2 + 3 * 4;
var result2 = (2 + 3) * 4;
Console.WriteLine($"{add}, {subtract}, {multiply}, {divide}, {divideDouble}, {modulus}, {result}, {result2}");
Console.WriteLine("===================================================");

// - 4

int practiceMinutes = 12;
Console.WriteLine($"Practice Minutes: {practiceMinutes}");
practiceMinutes += 8;
Console.WriteLine($"Practice Minutes: {practiceMinutes}");
practiceMinutes -= 2;
Console.WriteLine($"Practice Minutes: {practiceMinutes}");
practiceMinutes *= 3;
Console.WriteLine($"Practice Minutes: {practiceMinutes}");
practiceMinutes /= 4;
Console.WriteLine($"Practice Minutes: {practiceMinutes}");
practiceMinutes++;
Console.WriteLine($"Practice Minutes: {practiceMinutes}");
practiceMinutes--;
Console.WriteLine($"Practice Minutes: {practiceMinutes}");
Console.WriteLine("===================================================");

// - 5

int intNumber = 30;
double doubleNumber = intNumber;
Console.WriteLine($"Double: {doubleNumber}");

double realNumber = 9.7;
int intFromDouble = (int)realNumber;
Console.WriteLine($"Int: {intFromDouble}");

int convertedInt = Convert.ToInt32(realNumber);
Console.WriteLine($"Converted Int: {convertedInt}");

double calc1 = (double)7 / 2;
Console.WriteLine($"Calc1: {calc1}");
double calc2 = 7 / 2;
Console.WriteLine($"Calc2: {calc2}");
Console.WriteLine("===================================================");

// - 6

string textIntNumber = "48";
string textDoubleNumber = "3,75";
string textDecimalNumber = "9,90";

int parsedNumber = int.Parse(textIntNumber);
int convertedIntNumber = Convert.ToInt32(textIntNumber);
double parsedDouble = double.Parse(textDoubleNumber);
decimal parsedDecimal = decimal.Parse(textDecimalNumber);

Console.WriteLine($"{convertedIntNumber}, {parsedNumber}, {parsedDouble}, {parsedDecimal}");
Console.WriteLine("===================================================");

// - 7

string rowTopic = "  Learn C#   ";
Console.WriteLine($"Original Length: {rowTopic.Length}");
Console.WriteLine($"Clean Topic: {rowTopic.Trim()}");
Console.WriteLine($"Clean Length: {rowTopic.Trim().Length}");
Console.WriteLine($"Upper Case: {rowTopic.ToUpper()}");
Console.WriteLine($"Contains 'C#': {rowTopic.ToLower().Contains("c#")}");
Console.WriteLine($"Replacement: {rowTopic.Replace("C#", ".NET")}");
Console.WriteLine($"Row Topic: {rowTopic.Trim()}");
string emptyString = "   ";
bool isBlank = string.IsNullOrWhiteSpace(emptyString);
Console.WriteLine($"Blank input: {isBlank}");
Console.WriteLine("===================================================");

// - 8

Console.Write("Ismingizni kiriting: ");
string name = Console.ReadLine();

Console.Write("Mavzuni kiriting: ");
string topicInput = Console.ReadLine();

Console.Write("Masofani kiriting: ");
string distanceInput = Console.ReadLine();

Console.Write("Soatlardagi davomiylik: ");
string durationInput = Console.ReadLine();

name = name.Trim();
topic = topic.Trim();


double dist = double.Parse(distanceInput);
double duration = double.Parse(durationInput);

double speed = dist / duration;
Console.WriteLine($"Hello, {name.Trim()}! Today's topic: {topic.Trim()}.");
Console.WriteLine($"Average speed: {speed:F2} km/h");
Console.WriteLine("===================================================");

// - 9

int actualMinutes2 = 30;
int plannedMinutes2 = 40;

Console.WriteLine(actualMinutes2 == plannedMinutes2);
Console.WriteLine(actualMinutes2 != plannedMinutes2);
Console.WriteLine(actualMinutes2 > plannedMinutes2);
Console.WriteLine(actualMinutes2 < plannedMinutes2);
Console.WriteLine(actualMinutes2 >= plannedMinutes2);
Console.WriteLine(actualMinutes2 <= plannedMinutes2);
Console.WriteLine("===================================================");

// - 10

const int PlannedMinutes = 40;
const decimal HourlyPrice = 12.50m; 
decimal minutePrice = HourlyPrice / 60m;

Console.Write("Mavzuni kiriting: ");
string topic10 = Console.ReadLine();

Console.Write("Sarflangan daqiqa kiriting: ");
string actualMinutesInput = Console.ReadLine();

int actualMinutes10 = int.Parse(actualMinutesInput);
decimal cost = (actualMinutes10 * minutePrice);

int remainingMinutes = PlannedMinutes - actualMinutes10;
bool isCompleted = actualMinutes10 >= PlannedMinutes;
bool isWithinPlan = actualMinutes10 <= PlannedMinutes;
bool needsMoreTime = isWithinPlan && remainingMinutes > 0;


Console.WriteLine($"Topic: {topic10.Trim()}");
Console.WriteLine($"Planned: {PlannedMinutes}");
Console.WriteLine($"Actual: {actualMinutes10}");
Console.WriteLine($"Remaining: {remainingMinutes}");
Console.WriteLine($"Cost: ${cost:F2}");
Console.WriteLine($"Goal met: {isCompleted}");
Console.WriteLine($"Within plan: {isWithinPlan}");
Console.WriteLine($"Needs more time: {needsMoreTime}");
Console.WriteLine("===================================================");

// - 11

const int SecondsPerMinute = 60;
const int MinutesPerHour = 60;
const int SecondsPerHour = SecondsPerMinute * MinutesPerHour;

Console.Write("Jami sekundlar: ");
string totalSecondsInput = Console.ReadLine();
int totalSeconds = int.Parse(totalSecondsInput);

int hours11 = totalSeconds / SecondsPerHour;
int minutes11 = (totalSeconds % SecondsPerHour) / SecondsPerMinute;
int seconds11 = totalSeconds % SecondsPerMinute;

Console.WriteLine($"Soat: {hours11}, Daqiqa: {minutes11}, Sekund: {seconds11}");
Console.WriteLine("===================================================");

// - 12


