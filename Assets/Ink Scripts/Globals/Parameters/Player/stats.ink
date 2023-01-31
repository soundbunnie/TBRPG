/* 
PLAYER STATS
Min: 1
Max: 5
*/
VAR stats_loaded = false
{!stats_loaded:
/*
PHYSICAL STAT EXPLANATIONS:
Health is just a standard point system. 
    *Parametres will have to be tweaked
Acrobatics affects the players ability to do things like climb, balance, jump, etc
Strength affects the players ability to do things like lifting objects and busting down doors. 
    *Split this into multiple stats (?)
Foraging affects the players ability to collect herbs, foods, and alchemical ingredients
*/
// Physical stats
VAR Health = (10)
VAR Acrobatics = (1)
VAR Strength = (1)
VAR Foraging = (1)
VAR Discerning = (1)

/* 
SNEAKY STAT EXPLANATIONS:
Discerning is not to be confused with perception. Discerning affects the players ability to notice things in high pressure situations, such as noticing an enemy reaching for his knife.
Stealth is the players general ability to hide and sneak around.
Lockpicking affects the players ability to, well, lockpick.
Sleight of hand affects the players ability to do things like plant or yoink something on someone/somewhere
*/
// Sneaky stats
VAR Stealth = (1)
VAR Lockpicking = (1)
VAR SleightOfHand = (1)

/*
MENTAL STAT EXPLANATIONS:
Influence is the players ability to influence and persuade others.
Intimidation is the players ability to well, intimidate.
Negotation is the players ability to bargain, barter, or persuade someone to let you off the hook
Charm is the players likeability. Certain NPCs will treat them differently based on this stat.
Empathy is the ability to understand peoples emotions through things such as body language, speech, etc.
Logic is the players ability to reason and connect the dots between different points of knowledge.
Willpower is the players ability to persevere when things get tough. Higher willpower means a higher tolerance to pain, emotional distress, etc.
Introspection is the players ability to understand how they relate to the world around them. 
    *This stat is on the chopping block, but it could be interesting.
*/
// Mental stats
VAR Influence = (1)
VAR Intimidation = (1)
VAR Negotiation = (1)
VAR Charm = (1)
VAR Empathy = (1)
VAR Logic = (1)
VAR Willpower = (1)
VAR Introspection = (1)

/*
PASSIVE STAT EXPLANATIONS:
Perception is the ability to perceive things in normal situations, which is why this stat differs from discerning. The player is more prone to notice things like the change in weather or footsteps passively.
Reaction speed is a way of providing an alternative to discerning/perception. Instead of being proactive, you can instead be reactive.
History is the players knowledge of the world.
*/

// Passive stats
VAR Perception = (1)
VAR ReactionSpeed = (1)
VAR History = (1)
~ stats_loaded = true
}
/*
STAT BLOCKS
*/

=== function set_default_stats() ===
//Physical stats
~ Health = 10
~ Acrobatics = 1
~ Strength = 1
~ Foraging = 1
~ Discerning = 1

// Sneaky stats
~ Stealth = (1)
~ Lockpicking = (1)
~ SleightOfHand = (1)

// Mental stats
~ Influence = (1)
~ Intimidation = (1)
~ Negotiation = (1)
~ Charm = (1)
~ Empathy = (1)
~ Logic = (1)
~ Willpower = (1)
~ Introspection = (1)


// Passive stats
~ Perception = (1)
~ ReactionSpeed = (1)
~ History = (1)

=== function set_warrior_stats() ===
//Physical stats
~ Health = (10)
~ Acrobatics = (1)
~ Strength = (1)
~ Foraging = (1)
~ Discerning = (1)

// Sneaky stats
~ Stealth = (1)
~ Lockpicking = (1)
~ SleightOfHand = (1)

// Mental stats
~ Influence = (1)
~ Intimidation = (1)
~ Negotiation = (1)
~ Charm = (1)
~ Empathy = (1)
~ Logic = (1)
~ Willpower = (1)
~ Introspection = (1)


// Passive stats
~ Perception = (1)
~ ReactionSpeed = (1)
~ History = (1)

=== function set_thief_stats() ===
//Physical stats
~ Health = (10)
~ Acrobatics = (1)
~ Strength = (1)
~ Foraging = (1)
~ Discerning = (1)

// Sneaky stats
~ Stealth = (1)
~ Lockpicking = (1)
~ SleightOfHand = (1)

// Mental stats
~ Influence = (1)
~ Intimidation = (1)
~ Negotiation = (1)
~ Charm = (1)
~ Empathy = (1)
~ Logic = (1)
~ Willpower = (1)
~ Introspection = (1)


// Passive stats
~ Perception = (1)
~ ReactionSpeed = (1)
~ History = (1)

=== function set_alchemist_stats===
//Physical stats
~ Health = (10)
~ Acrobatics = (1)
~ Strength = (1)
~ Foraging = (1)
~ Discerning = (1)

// Sneaky stats
~ Stealth = (1)
~ Lockpicking = (1)
~ SleightOfHand = (1)

// Mental stats
~ Influence = (1)
~ Intimidation = (1)
~ Negotiation = (1)
~ Charm = (1)
~ Empathy = (1)
~ Logic = (1)
~ Willpower = (1)
~ Introspection = (1)


// Passive stats
~ Perception = (1)
~ ReactionSpeed = (1)
~ History = (1)


