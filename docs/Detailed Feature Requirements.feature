# Detailed Features List

## Minimum Viable Product Features

### A

Feature: Operational Game - Functional

    The base operational game allows two players to fight against
    each other in a single round that lasts until one of them is dead or they run out of weapons.

    #### A1

    Scenario: A Player starts game

        When Player starts the game.

        Then Player is presented a title screen, they are prompted to press start
    to begin.

    #### A2

    Scenario: A Player press start

        When A Player press start.

        Then Players are presented a screen to select map, weapons, and tank color.


    #### A3

    Scenario: Players makes choices and press continue

        When Players confirm choices

        Then Map loads in with selected weapons and tanks and
    the players are placed in positions on opposite sides.

    #### A4

    Scenario: Player defeats other player

        When A Player brings the other players health to 0

        Then A "Player(#) Wins!" screen is displayed. Once confirmed they are
    given the option to quit or re-play.

    #### A5

    Scenario: Players use all weapons with unequal health

        When Players use all selected weapons and have unequal health

        Then The Player with the most health is declared the winner,
    resulting in a "Player(#) Wins!" screen. Once confirmed they are given
    the option to quit or re-play.

    #### A6

    Scenario: Players use all weapons and have equal health

        When Players use all weapons and have equal health

        Then A "Draw!" screen is presented. Once confirmed they are given
the option to quit or re-play.

### B

Feature: Basic Movement - Functional

    The players are able to move their tanks left and right.
    They are also able to adjust the angle of their cannon and
    the power of their shot.

    #### B1

    Scenario: Player presses left or right arrows

        When Players press left or right

        Then The players tank moves in the corresponding direction.

    #### B2

    Scenario: Player presses up or down

        When Players press left or right

        Then The players shot angle changes in the corresponding direction.

    #### B3

    Scenario: Player presses < or > keys

        When Players press < or >

        Then The players shot power decreases or increases accordingly

### C

Feature: Physics Based Aiming System - Functional

    The weapons that are designated as physics dependent will be affected by factoring gravity
    and the force generated by their propulsion. Weapons that are not physics dependent
    will not be affected by gravity and will

    #### C1

    Scenario: Player fires physics based shot

        When Player fires physics based shot

        Then Shot travels in an arc based on angle, shot power, propulsion type, and gravity

    #### C2

    Scenario: Player fires non-physics based shot

        When Player fires non-physics based Shot

        Then Shot travels based on angle, shot power, and its pre-determined flight path

## Full Game Features

### D

Feature: Local Accounts - Functional

Players will have local accounts with which to save user settings and Statistics.
These will have the option to use a passcode but it will not be required.

### E

Feature: Local Statistics Tracker - Functional

Tracks data from player matches and stores them on a viewable scoreboard. Data
will be tracked based on user account and will include: shots fired, shots hit
vs shots missed, win/loss record, and distance traveled.

### F

Feature: Level destruction from weapons - Functional

    Weapons that have landscaping attributes will develope the level based on their area of effect.

    #### F1

    Scenario: Weapon with landscaping attribute hits terrain.

        When Weapon with landscaping attribute hits terrain

        Then Terrain is destroyed based on the area of effect of the weapon.

    ### F2

    Scenario: Weapon without landscaping attribute hits terrain.

        When Weapon without landscaping attribute hits terrain.

        Then No terrain is destroyed.


### G

Feature: Tank Customization - Functional

Players are able to select tank type and color. These settings are purely aeshetic and do
not alter the game.

## Stretch Goal Features

### H

Feature: Network Multiplayer

Players are able to play matches against each other over the internet.

### I

Feature: Website with global scoreboard and forum

    Players will have their local user accounts linked to a website with a
    username and password login. Their local stats will be pushed to this site
    and be placed on a global scoreboard giving them a numerical ranking based on their
    stats. There will also be a forum where players can interact with each other and give
    feedback about features and bugs.

    #### I1

    Scenario: Player opens website

        When Player opens the website

        Then They are asked to type their username and login.

    #### I2

    Scenario: Player logs in

        When Player logs in

        Then They are taken to the main page of the website which displays the global leaderboard.

    #### I3

    Scenario: Player clicks on forum link

        When The Player clicks on the forum link

        Then They are taken to the forums page and given the option to select a forum or create a new one.


    #### I4

    Scenario: Player selects a forum

        When The Player selects a forum

        Then They are taken into that forum and are able to read the forum and add comments on it.

    #### I5

    Scenario: Player creates a forum

        When The Player creates a forum

        Then They are taken to a creation screen and asked to name the forum, give a quick description,
and insert the first forum comment.

### J

Feature: Procedurally Generated Maps

The terrain of the levels is randomly generated making each game unique.
The players are able to save generated terrains as favorites for future replay.

### K

Feature: User Map Creation Tool

Users are able to use a map creation tool, similar to paint, to create terrains for them to play on.

### L

Feature: Social Media Connectivity

Users are able to link their social media accounts to the game and website to share stats, forums,
and user created levels.

### M

Feature: Computer AI Opponents

Players are able to play against opponents that are controlled by the computer. This will include
adjustable difficulty settings. These matches will not affect stats.