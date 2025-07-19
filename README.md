# 🏗️ Abstract Factory Pattern – C# Implementation

This project demonstrates the **Abstract Factory Pattern** in C#, as part of a broader Design Patterns learning series.

## 🧠 Concept

The **Abstract Factory Pattern** provides a way to encapsulate a group of individual factories that are related by theme, allowing you to create families of related objects without specifying their concrete classes.

> It helps you create consistent groups of objects, and switch the entire group (family) easily, without changing client code.

---

## 🚚 Scenario: Package Delivery System

In this example, we simulate a delivery system that selects the delivery method based on the package weight:

- **Bike** for packages up to 3kg  
- **Motorcycle** for packages up to 10kg  
- **Truck** for heavier packages

Each delivery type comes with:
- A specific **Transport**
- A corresponding **Receipt Document**
- A **Tracking System**

All of these are created through a single factory per delivery type.

---

## 🧩 Structure

### 🔨 Interfaces

- `ILogisticFactory` – Abstract factory interface
- `ITransport`, `IReceit`, `ITracker` – Product interfaces

### 🏭 Concrete Factories

- `BikeLogisticsFactory`
- `MotoFactory`
- `TruckLogisticFactory`

Each factory creates a matching set of:
- Transport
- Receipt
- Tracker

### 👨‍💻 Client Code

```csharp
ILogisticFactory factory = weight switch
{
    <= 3 => new BikeLogisticsFactory(),
    <= 10 => new MotoFactory(),
    _ => new TruckLogisticFactory()
};

var transport = factory.CreateTransport();
var document = factory.CreateReceit();
var tracker = factory.CreateTracker();
