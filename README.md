# AnyWashAutoTests
# Проект с функциональными UI-Тестами по интерфейсу партнера AnyWash


Платформа: .NET Core 3.1, NUnit

Фрэймворки:
Selenium WebDriver + ChromeDriver
SpecFlow
LivingDoc


Для запуска тестов необходимо:
1. Открыть командную строку
2. При помощи команды cd указать путь к папке "AnyWashAutotests"
3. Запустить тесты: dotnet test
4. Для запуска тестов по конкретному интерфейсу использовать команду: dotnet test --filter Category=<tag>
  
Тэги:
PartnerMainPageInterface - интерфейс ЛК партнера
CarWashInterface - интерфейс мойки
TireFittingInterface - интерфейс шиномонтажа

Для корректной работы необходим ChromeDriver последней стабильной версии, соответствующий версии браузера Google Chrome:
https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/96.0.4664.1800-beta
https://github.com/jsakamoto/nupkg-selenium-webdriver-chromedriver/

Чтобы посмотреть отчет по прогону тестов необходимо открыть файл LivingDoc.Html по пути AnyWashAutotests\bin\Debug\netcoreapp3.1
