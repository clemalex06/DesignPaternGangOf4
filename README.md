# DesignPaternGangOf4
C# command line solution to implement the basics design Patterns of Gang Of 4.
To know more about the topic, check this link : 
[refactoring guru design patterns](https://refactoring.guru/design-patterns)

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

        /*
         *
         *Concept du Command
         * a pour objectif de transformer une requête en un objet
         * facilitant des opérattions comme l'annulation, la mise en file des
         * requêtes et leur suivi
         * 
         */

    Interpreter

        /*
         *
         * Concept de l'interpreter
         * fournit un cadre pour donner une représentation par objets de la
         * grammaire d'un langage afin d'évaluer, en les intérprétant,
         * des expressions écrites dans ce langage
         * 
         */

    Iterator

    /*
     * 
     * Concept de l'iterator
     * fournit u accès séquentiel à une collection d'objets
     * sans que les clients se préoccupent de l'implémentation de cette collection
     * 
     */

    Mediator

    /*
     *
     * Concept du Mediator
     * construit un objet dont la vocation est la gestion
     * et le controle des interactions au sein d'un ensemble d'objets sans
     * que ces éléments se connaissent mutuellement
     * 
     */

    Memento

    /*
     *
     * Concept du memento :
     * sauvegarde et restaure l'etat d'un objet
     * 
     */

    Observer

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