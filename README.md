# FPS Player Controllers

This repository contains different types of FPS player controller implementations.

TODO: Releases in Asset Store?

## Table of Contents

- [Project Structure](#project-structure)
    - [Camera Controller](#camera-controller)
- [Controllers](#controllers)
    - [Character controller](#character-controller)
    - [Input System](#input-system)
    - [Rigid Bydy Controllers](#rigid-body-controllers)
        - [Rigid Body - Add Force](#rigid-body---add-force)
        - [Rigid Body - Velocity](#rigid-body---velocity)
    - [Transform  Component](#transform-component)
- [Releases](#releases) 
- [Contribution](#contribution)

## Project Structure

On the top-level we have the following directories:

Controllers: This directory houses all the different FPS player controllers.
This includes the prefabs containing all the necessary components to make the controller work, a scene where this controller is ready to be tested and the script implementing the required logic for the controller.

Misc: This directory contains scripts that enable the character controller, such as the [Camera Controller](#camera-controller).

Test Plane: Houses a sample plane used in the test scenes.

### Camera Controller

NOTE: The camera is a child of the controllers. This allows to update the cameras position by simply updating the players position.

When the camera rotates the rotation is applied to the target, which is set to the the parent, i.e. the player controller.

## Controllers

Different controller implementation will look and feel different to the developer and to the player. The reason why the different types of controllers are split is so, that each developer can pick and choose which implementation feels best for them and their unique use cases.

### Character Controller

[CharacterController official documentation]()

The Move and SimpleMove both use the same implementation from the Base class.

TODO: Difference between controllers
TODO: Need Time.DeltaTime

NOTE: This implementation does not provide gravity out-of-the-box.

### Input System

[Input System latest release]()

TODO:

### Rigid Body Controllers

TODO: Differences between Add Force and velocity

Read more about [Rigidbody]()

#### Rigid Body - Add Force

[Rigidbody.AddForce() official documentation]()
[Rigidbody - AddForce implementation latest release]()

As the name of the implementation suggests, each frame the forces are summed from the input of te current frame to the existing force, which leads the player to accelerating if button is pushed down.

#### Rigid Body - velocity

[Rigidbody.velocity official documentation]()
[Rigidbody - velocity implementation latest release]()

This approach results to pretty much to the same as the [Character Controller](#character-controller) Move and SimpleMove. 

This method has the added benefit from all that the rigid body class brings to the table.

### Transform Component

[Transform official documentation]()

TODO: Differences between Translate and Position

#### Translate

[Transform.Translate() official documentation]()
[Transoform - Translate implementation latest release]()

TODO: Fix movement direction in script

The Transform.Translate() method is similar to the [Character Controller](#character-controller) Move() and SimpleMove() implementations.

TODO: Similarities

TODO: Differences

#### Position

[Transform.position official documentation]()
[Transoform - position implementation latest release]()

Editing the Transform.position is a cheap action, but this implementation has pretty big drawbacks:

1. There is no gravity
2. There is no collision checks

All these things you would either need to implement manually or use a different component to handle them for you.

If you only ever need to move a player to a specifc direction some amount without needing to care about collisions or gravity etc. this is the most performant option.

## Releases

All the different types of controllers can be found as Unity packages from the releases page [Here](todo add the link).

## Contribution

If you wish to contribute to the project, you must follow these rules:
1. When starting to work on a feature, create a new feature branch with a descriptive name using kebab-case. Ex. ```rigidbody-addforce-unit-tests```.
2. When you are done working on your changes, merge main onto your branch and test that nothing is broken. This ensures that no merge conflicts should occur when creating your pull request. This saves a lot of time and headaches.
3. Create a pull request to ```main``` for your changes to be review. Once the owner has approved your changes, you can merge in your changes. When creating pull request, please use descriptive titles and a give a brief summary of what it is you have done.

Thank you for begin considerate! :)
