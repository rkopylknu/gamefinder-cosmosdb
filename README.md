# gamestores-cosmosdb

## Потреби
Для використання застосунку необхідна наявність Azure Cosmos DB (API for MongoDB) акаунту.

## Інструкція з встановлення:
1. Завантажте та розпакуйте архів програми
2. Відкрийте видобуту папку
3. Перейдіть за шляхом:

   ```
   GameFinder\DI
   ```
4. За допомогою будь-якого редактора відкрийте *RepositoryModule.cs*
5. Замініть текст:

   ```
   <INSERT CONNECTION STRING HERE>
   ```
на рядок підключення вашого Cosmos DB акаунту.

Якщо всі шляхи було виконано правильно, повинен запуститися Windows Forms застосунок з початковим набором даних
