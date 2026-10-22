int correctPin = 5555;
int attempts = 3;
bool access = false;

while (attempts > 0)
{
    Console.Write("Введите PIN-код: ");
    int pin = int.Parse(Console.ReadLine());

    if (pin == correctPin)
    {
        access = true;
        break;
    }

    attempts--;
    Console.WriteLine($"Неверный PIN. Осталось попыток: {attempts}");
}

if (access)
{
    int total = 0;

    while (true)
    {
        Console.Write("Введите сумму снятия (0 - завершить): ");
        int amount = int.Parse(Console.ReadLine());

        if (amount == 0)
        {
            break;
        }

        total += amount;
    }

    Console.WriteLine($"Итоговая снятая сумма: {total}");
}
else
{
    Console.WriteLine("Карта заблокирована");
}