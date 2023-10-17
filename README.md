# Facebook App

The Facebook app provides users with access to their Facebook profiles and the ability to modify them. The app utilizes the Facebook API to offer users a seamless experience and incorporates advanced features such as multithreading and various design patterns to ensure optimal performance and scalability. For each design pattern used, UML diagrams, including class diagrams and sequence diagrams, were created to ensure that the project was well-organized and designed.

The Facebook app is built using C# and WinForms and was created as part of a design pattern course at the Academic College of Tel Aviv Yaffo.

## Features

### Find My Match

#### Description
The "Find My Match" feature is designed to help users find potential romantic matches among their Facebook friends. Users can define their preferences, including gender, age range, and preferred locations. The system then searches the user's single Facebook friends to suggest suitable matches based on these criteria.

#### Implementation
- **User Interface:**
  - FindMyMatchForm
  - MyOptionalMatchesForm
  - SelectedMatchForm

- **Logic and Algorithms:**
  - IMatchStrategy (interface for matching strategies)
  - FilterByGenderStrategy (filtering matches by gender)
  - FilterByCitiesStrategy (filtering matches by cities)
  - FindMyMatchLogic (core logic for finding matches)
  - FindMyMatchFacade (facade for accessing the feature)

**Design Pattern:**
- This feature incorporates the **Strategy Pattern** to allow dynamic selection of matching strategies (e.g., filtering by gender or city) without modifying the client code. This pattern helps improve code reusability and maintainability.

**Note:** Please be aware that Facebook API permissions may limit access to a user's list of friends.

### Album Insights

#### Description
The Album Insights feature provides users with detailed information about their photo albums. Users can sort their albums using various criteria, including the number of photos, comments, or the most recent update date. Users can also obtain statistics on the number of photos uploaded to albums by year and by month.

#### Implementation
- **User Interface:**
  - AlbumsForm
  - AlbumStatisticsByMonthsForm
  - AlbumStatisticsByYearsForm

- **Logic and Algorithms:**
  - AlbumStatisticsLogic (core logic for album statistics)
  - SortedAlbumsByDifferentCategoriesLogic (logic for sorting albums by different categories)
  - AlbumStatisticsByMonthsLogic (logic for album statistics by months)
  - AlbumStatisticsByYearsLogic (logic for album statistics by years)

**Design Pattern:**
- The **Template Method Pattern** is used in the Album Statistics feature to avoid code duplication when calculating statistics for both years and months. This pattern allows for the reuse of the algorithm with specific steps implemented in derived classes. It enhances code maintainability and extensibility.

## Installation

To install the Facebook app, follow these steps:

1. Clone the repository from GitHub.
2. Open the solution file in Visual Studio.
3. Install the required packages.
4. Build the solution and run the app.

## Usage

To use the Facebook app, follow these steps:

1. Log in to the app using your Facebook credentials.
2. Navigate to the desired feature from the app menu.
3. Enjoy the features and have fun!

## About

The Facebook app was created by Shiraz Yom Tov and Ido Singer as part of a design pattern course at the Academic College of Tel Aviv Yaffo. This project allowed us to showcase our skills and expertise in advanced app development techniques such as multithreading and design patterns.
