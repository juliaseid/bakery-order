# _Bakery Order Site_

#### May 8th, 2020

## Description

_This website is a functional back end for a bakery ordering app, including multiple product categories and pricing methods to generate an order total._

__

## Setup/Installation Requirements

_Make sure you have [git version control](https://git-scm.com/downloads) installed on your computer._

1. Click the green 'Clone or Download' button and copy the link / download the zip
2. Open terminal and type... or skip to #4 if you downloaded the zip

**Windows**

```sh
cd desktop
```

Mac & linux

```sh
cd ~/Desktop
```

3.  in terminal type '_git clone {link to repository}_ '

```sh
git clone {link to repository}
```
4. If you downloaded the zip then extract all onto your desktop
5. Open the folder with VSC or an equivalent
6. Download .NET Core Sdk 3.1 & Run _dotnet -- version_ in the terminal to confirm installation
7. In the terminal Run _dotnet tool install -g dotnet-script_
8. Open project & Run _dotnet run_
9. Enjoy

## Specs

### Behavior Driven Development Spec List
#### Bakery Order Site
|                          Behavior                          | Input  | Output  |
| :--------------------------------------------------------: | :----: | :-----: |
| 1. The program will ask users to enter a number of loaves of bread | '2' | 'The program will confirm that number and offer 1 free loaf for every 2: "You've earned 1 free loaf! Would you like it?"'  |
| 2. The program ask users to enter a number of pastries| '3' | 'The program will confirm the number of pastries and, if the number is not divisible by 3, remind users that the 3rd pastry is discounted and offer a chance to add additional pastries.' |
| 3. The program will show users their total order when they confirm | 'confirm order' | 'You've ordered 3 loaves of bread and 3 pastries.' |
| 4. The program will offer users the chance to start over | 'no, new order' | 'revert to behavior 1' |
| 5. The program will show a total price if user confirms order | 'OK' | 'Your total cost is $15' |



---
## Known Bugs

_N/A_ - 5/8/2020

## gh-pages

https://github.com/juliaseid/bakery-order

## Support

_Email: juliaseid@gmail.com_

---
## Built With

- [C#/.Net]


## Useful tools


---
### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Julia Seidman_**