# DesignPaternGangOf4
C# command line solution to implement the basics design Patterns of Gang Of 4

## Construction Design Patterns 

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

## Structuration Design Patterns 

### Adapter's Concept : 
Allows objects with incompatible interfaces to collaborate.

### Bridge's Concept :
Lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.


### Composite's Concept :
Lets you compose objects into tree structures and then work with these structures as if they were individual objects.

    Decorator

    /*
     *
     * Permet d'ajouter dynamiquement des fonctionnalités supplémentaires
     * à un objet 
     * 
     */

    Facade

    /*
     *
     *Concept de la Facade
     * a pour but de regrouper les interfaces d'un ensemble
     * d'objets en une interface unifiée rendant cet ensemble plus simple
     * à utiliser
     * 
     */

    FlighWeight

    /*
     *
     *Concept du FlyWeight
     * facilite le partage d'un ensemble importants
     * d'objets dont le grain est fin
     * 
     */

    Proxy

    /*
     *
     * Concept du PROXY
     * construit un objet qui se substitue à unautre objet et
     * qui controle son acces
     * 
     */

Comportement
    ChainOfResponsability

    /*
     *
     * Concept de la ChainOfResponsability
     *  crée une chaine d'objet telle que si un objet de la chaine
     *  ne peut pas répondre à une requête, il puisse la transmettre à ses
     *  successeurs jusqu'à ce que l'un d'entre eux y réponde
     * 
     */

    Command

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