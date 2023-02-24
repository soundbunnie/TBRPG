/*
Stats explanation

Strength // Ability to overcome obstacles using physical strength (i.e breaking down a door, forcing open a lock,)
Dexterity // A higher dexterity means that you move better, more precisely, and are able to preform tasks that require nimbleness.
Willpower // Your ability to persevere. A higher willpower means that you will be able to withstand pain, fear, emotions, etc...
Intelligence // Your ability to reason, understand, and make connections.
Influence // Your ability to influence others, be it by strength, deception, charm, etc...
Perception // This influences your reaction time and your observation skills. Someone with a high perception will notice things that others do not.

each stats dice will increase as you put points into it (6, 8, 10, 12)
there can be temporary stat dice increases

dice can be rolled together. if you want to intimidate someone by physical means, you would roll strength + influence

*/

VAR Strength = 1
VAR Dexterity = 1
VAR Willpower = 1
VAR Intellignece = 1
VAR Influence = 1
VAR Perception = 1


=== function set_default_stats() ===
~ Strength = RANDOM(1, 6)
~ Dexterity = RANDOM(1, 6)
~ Willpower = RANDOM(1, 6)
~ Intellignece = RANDOM(1, 6)
~ Influence = RANDOM(1, 6)
~ Perception = RANDOM(1, 6)

=== function set_warrior_stats() ===
~ Strength = RANDOM(1, 6)
~ Dexterity = RANDOM(1, 6)
~ Willpower = RANDOM(1, 6)
~ Intellignece = RANDOM(1, 6)
~ Influence = RANDOM(1, 6)
~ Perception = RANDOM(1, 6)

=== function set_thief_stats() ===
~ Strength = RANDOM(1, 6)
~ Dexterity = RANDOM(1, 6)
~ Willpower = RANDOM(1, 6)
~ Intellignece = RANDOM(1, 6)
~ Influence = RANDOM(1, 6)
~ Perception = RANDOM(1, 6)

=== function set_alchemist_stats===
~ Strength = RANDOM(1, 6)
~ Dexterity = RANDOM(1, 6)
~ Willpower = RANDOM(1, 6)
~ Intellignece = RANDOM(1, 6)
~ Influence = RANDOM(1, 6)
~ Perception = RANDOM(1, 6)

