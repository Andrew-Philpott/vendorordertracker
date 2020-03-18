# VendorOrderTracker

#### C# Basic Web Applications Exercise for [Epicodus](https://www.epicodus.com/), 03.12.2020

#### By **Andrew Philpott**

## Summary

Updated project to start using entity. Struggled with figuring out how to send a dynamically created form to a route. Planning on extending this project to be a resource for viewing orders, employees, inventory.

## Description

Application that allows a user to keep track of the orders placed with different vendors. User can add or remove vendors, and add or remove orders for each vendor.

## Specs

- _Spec: Vendor constructor should be able to correctly make a vendor object._

  - Input: new Vendor()
  - Output: Vendor

- _Spec: Order constructor should be able to correctly make an order object._

  - Input: new Order()
  - Output: Order

- _Spec: The application should inform the user that there are no vendors if none have been created._

  - Input:
  - Output: You don't have any vendors yet

- _Spec: The application should return to the home page when a vendor object has been created_

  - Input: Create vendor object via new page
  - Output: Home page

- _Spec: The application should inform the user that no orders have been placed with a vendor if an order for that vendor doesnt exist._

  - Input: Vendor Andrew Philpott
  - Output: No orders have been placed yet with Andrew Philpott

- _Spec: The application should return to the vendor when an order has been placed._

  - Input: Vendor Andrew Philott new order()
  - Output: Andrew Philpott with order listed.

## Setup/Installation Requirements

- Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
- Clone this [repository](https://github.com/ayohana/anagram.git/)
- Open the `Command Line Interface`.
  - Navigate into the `VendorOrderTracker` directory.
    - Type in the command `dotnet restore` to gather tools and dependencies for the application.
    - Type in the command `dotnet run` to run the application.

## Known Bugs

No known bugs at this time.

## Support and contact details

Feel free to provide feedback via email: andrewphilpott92@gmail.com

## Technologies Used

- C#
- [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
- MVC Pattern

### License

This C# web application is licensed under the MIT license.

Copyright (c) 2020 **Andrew Philpott**
