# DesignPaternGangOf4
C# command line solution to implement the basics design Patterns of Gang Of 4.
To know more about the topic, check this link : 
[refactoring guru design patterns](https://refactoring.guru/design-patterns)

Another interesting link about SOLID Principles
[SOLID Principles](https://www.baeldung.com/solid-principles)

## Creational Design Patterns
[Creational Design Patterns from Reafctoring Guru](https://refactoring.guru/design-patterns/creational-patterns)

### Abstract Factory 
Aims to create objects grouped into families without having to know the concrete classes intended for the creation of these objects.
   
### Builder's Concept :
Allows the construction of complex objects to be separated from their layout, so that a client can create these complex objects with different layouts.

### Factory Method's Concept :
Defines an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

### Prototype's Concept :
Creates duplicate object while keeping performance in mind. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.

### Singleton's Concept :
Restricts the instantiation of a class to one "single" instance.

## Structural Design Patterns
[Structural Design Patterns from Reafctoring Guru](https://refactoring.guru/design-patterns/structural-patterns)

### Adapter's Concept : 
Allows objects with incompatible interfaces to collaborate.

### Bridge's Concept :
Lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

### Composite's Concept :
Lets you compose objects into tree structures and then work with these structures as if they were individual objects.

### Decorator's Concept :
Lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.


### Facade's Concept :
Provides a simplified interface to a library, a framework, or any other complex set of classes.

### FlighWeight's Concept :
Lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object.

### Proxy's Concept :
Lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

## Behavioral Design Patterns
[Behavioral Design Patterns from Reafctoring Guru](https://refactoring.guru/design-patterns/behavioral-patterns)

### Chain of Responsibility's Concept :
Lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

### Command's Concept :
Turns a request into a stand-alone object that contains all information about the request. 
This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.

### Interpreter's Concept :	 
Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
Map a domain to a language, the language to a grammar, and the grammar to a hierarchical object-oriented design.

### Iterator's Concept :	 
Lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).

### Mediator's Concept :
Lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

### Memento's Concept :
Lets you save and restore the previous state of an object without revealing the details of its implementation.

### Observer's Concept :
Lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.

    /*
     *
     * Concept de l'adapter
     * construit une dépdendance entre un sujet et des observateurs de façon à ce que
     * chaque modification du sujet soit notifiée aux observateurs
     * afin qu'ils puissent mettre à jour leurs état
     * 
     */

    State

    /*
     *
     * Concept du State
     * permet a un objet d'adapter son comportement en fonction de son etat
     * interne
     * 
     */

    Strategy

    /*
     *
     * Concept du Strategy
     * adatpte le comportement et les algorithmes d'un objet en fonction
     * d'un besoin sans changer les interactions avec le client de cet objet
     * 
     */

    TemplateMethod

    /*
     *
     * Concept du template Method
     * Permet de reporter dans des sous-classes certaines étapes de l'une
     * des opérations d'un objet, ces étapes étant alors décrites dans
     * les sous classes
     * 
     */

    Visitor

    /*
     *
     *Concept du Visitor
     * construit une opération à réaliser sur les éléments d'un ensemble
     * d'objets. De nouvelles opérations peuvent ainsi être ajoutées
     * sans modifier les classes de ces objets
     * 
     */

Autres

    Pluggable Factory

    /*
     *
     *Concept du pluggable Factory
     * Abstract Factory + Prototype
     * 
     */

    Reflective Visitor
    /*
     *
     * Concept du reflective Visitor :
     * Visitor + Composite
     * 
     */

    Multicast
    /*
     *
     * Concept du Multicast
     * gérer les évènements produits dans un programme afin de les transmettre
     * à un ensemble de récepteurs concernés. Le pattern est basé sur un mécanisme
     * d'inscription des récepteurs auprès des expéditeurs
     * 
     */