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

## Design Patterns Used

The Facebook app incorporates several design patterns to improve code maintainability, reusability, and extensibility. Here are the design patterns used in the project:

### Factory Method Pattern

**Use of the Pattern:** The Factory Method pattern is used to create a polymorphic family of classes that inherit from the Form class. This pattern helps move the responsibility of creation from the Client to a separate class, improving code maintainability and avoiding code duplication.

**Implementation Approach:** A static class named FormFactory was created. It contains a static function called CreateForm, which takes parameters and creates the relevant Form based on the specified eFormType.

### Facade Pattern

**Use of the Pattern:** The Facade pattern simplifies the usage of logical components and abstracts data, making it more manageable. It improves system maintainability by wrapping the logical component in the Facade class, enhancing the safety of system usage.

**Implementation Approach:** The FindMyMatchFacade class was created for SelectedMatchForm and MyOptionalMatchesForm. It calls FindMyMatchLogic and UserLogic to obtain the required data. The FindMyMatchFacade class holds fields for FindMyMatchLogic and UserLogic to fetch the necessary data.

### Singleton Pattern

**Use of the Pattern:** The Singleton pattern is used to ensure only one instance of a class is created, allowing components to access this instance on their initiative. It is used to prevent multiple instances of the UserLogic class, improving efficiency.

**Implementation Approach:** The Singleton pattern was implemented in the UserLogic class, ensuring only one instance is created. A private constructor, sealing the class, and a static instance (s_Instance) were used to achieve this pattern.

### Strategy Pattern

**Use of the Pattern:** The Strategy pattern is used to allow dynamic selection of matching strategies for filtering in the "Find My Match" feature. It prevents code duplication, saves future code duplication, and makes the code open for extensions.

**Implementation Approach:** The FindMyMatchLogic class holds a List of IMatchStrategy for filtering. Different strategies (FilterByGenderStrategy and FilterByCitiesStrategy) are used to determine how to filter the list of matches based on user preferences.

### Iterator Pattern

**Use of the Pattern:** The Iterator pattern is used to allow users to scan the list of friends based on chosen filtering criteria without being aware of the data structure implemented in the logic layer. It separates logic from the UI and ensures future changes in data structure won't affect the user interface.

**Implementation Approach:** The FriendsFilter class implements the IEnumerable<FriendLogic> interface, allowing filtering of a list of friends based on user criteria without exposing the data structure.

### Template Method Pattern

**Use of the Pattern:** The Template Method pattern is used to avoid code duplication between AlbumStatisticsByYearsLogic and AlbumStatisticsByMonthsLogic. It enables code reuse and saves potential future code duplication. It allows the code to be open to extensions, such as adding new statistics.

**Implementation Approach:** The abstract class AlbumStatisticsLogic contains the template method GetStatisticsAboutAmountOfPhotos, while specific implementations for AlbumStatisticsByYearsLogic and AlbumStatisticsByMonthsLogic handle the injection points for statistics calculation.

These design patterns contribute to the overall maintainability, reusability, and extensibility of the Facebook app project.


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
