# AnyWashAutoTests

Платформа: .NET Core 3.1, NUnit

Фрэймворки:
Selenium WebDriver + ChromeDriver последней версии
SpecFlow
LivingDoc


Для запуска тестов необходимо:
1. Открыть командную строку
2. При помощи команды cd указать путь к папке "AnyWashAutotests"
3. Запустить тесты: dotnet test
4. Для запуска тестов по конкретному интерфейсу использовать команду: dotnet test --filter Category=<tag>

Тэги:
@PartnerMainPageInterface - интерфейс ЛК партнера
@CarWashInterface - интерфейс мойки
@TireFittingInterface - интерфейс шиномонтажа
