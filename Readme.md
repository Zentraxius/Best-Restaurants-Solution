# _Best Restaurants_

#### _A practice in C Sharp in Databases with a Best Restaurants application., 2020 ver 1.0_

#### By _Ian Gregg & Cody Fritz_
[Best-Restaurants-Solution](https://github.com/oldgregg89/Best-Restaurants-Solution)

## Description

_A practice in C Sharp in Databases with a Best Restaurants application._

## Setup/Installation Requirements

* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing 'dotnet tool installl -g dotnet-script' in the command line
* type dotnet build in the command line to compile the code
* create a .gitignore file and store the bin and obj folders in .gitignore
* type dotnet run in the command line to run the program
* run `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`  &
`dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
in the terminal
* add a file called `appsetting.json` in the BestRestaurants directory.
* in `appsetting.json` add ![appsetting.json](Assets/setup.png)
* fill in your `server`, `port`,`database`,`uid`, and `pwd`

__

## Specs

| Behavior    | Input | Output |
| :---------- | ----- | -----: |
| Create a new Restaurant | `add`new restaurant "Billy's grill" | `details` "Billy's grill" |
| Edit a Restaurant | `edit` name, description, and/or "Billys grill, BBQ grill spot, $$" to "maggy's grill"  | `details displayed` "maggys's grill, BBQ gril spot, $$" |
| Deleted Restaurant | `delete` "maggy's grill" | `details` no display |
| Create new Restaurant | `create` "Phil's Cold cut Sandwiches, Best sandwhiches in the city, $" | `details` "Phil's Cold cut Sandwiches, Best sandwhiches in the city, $" |



## Known Bugs

_No known bugs_

## Support and contact details

_Contact Ian Gregg: <iangregg188@gmail.com>
or
Cody Fritz <clanalia55@gmail.com>_

## Technologies Used

_The Technologies used in the making of this software was Chrome browser, Visual Studio editor, and Mac, C#, .Net_

### License

Copyright (c) 2020 **_Ian Gregg & Cody Fritz_**

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.