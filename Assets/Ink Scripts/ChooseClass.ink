INCLUDE globals.ink
-> choose_class

=== choose_class ===
After some exposition, or dialogue, or something, it's time to decide who you are.
    + [I am a Warrior. I'll come home with my shield or on it.]
        -> warrior_choose_traits
    + [I am an alchemist. Most will call me a witch, but my brews are simply the results of many years of study in my field.]
        -> alchemist_choose_traits
    + [I am a thief. My slick words and sitcky fingers get me in and out of trouble.]
        -> thief_choose_traits
    
=== warrior_choose_traits ===
    ~ player_class = "Warrior"
    {add_skill(Running)}
    {add_trait(Revered)}
    
    // Physical stats
    ~ Strength = 4
    ~ Stealth = 2
    
    // Mental stats
    ~ Influence = 3
    ~ Empathy = 2
    ~ Logic = 1
    ~ Willpower = 3
    ~ Introspection = 1
    
    // Passive stats
    ~ Perception = 3
    ~ History = 1
    
    What do you fight for?
    + [I fight for myself. The thrill of an honourable fight keeps me sane.] 
    // + Honourable, Introspection
        {add_trait(Honourable)}
        ~ Introspection += 1
        ~ player_title = "Honourable Warrior"
        -> choose_background
    + [I fight for power and status. Being able to step on the backs of others to get to the top means that I was stronger.] 
    // + Influence, Immoral - Empathy
        {add_trait(Immoral)}
        ~ Influence += 1
        ~ Empathy -= 1
        ~ player_title = "Powerhungry Warrior"
        -> choose_background
    + [I fight to survive. Picking locks is a waste of time when I can just break down the door.] 
    // + Willpower, Survivor
        {add_trait(Survivor)}
        ~ Willpower += 1
        ~ player_title = "Survivor"
        -> choose_background
    + [I fight to protect those who cannot defend themselves. Making somebodys life a little bit better makes me feel like I've earned my place in this world.]
    // + Moral, Generous, Empathy
        {add_trait(Moral)}
        {add_trait(Generous)}
        ~ Empathy += 1
        ~ player_title = "Chivalrous Warrior"
        -> choose_background
    + [I'm a mercenary. I know how to handle myself and I'm well paid, so long as I survive to the next day.]
    // + Negotiation, Cunning, Introspection, Perception
        {add_skill(Negotiation)}
        {add_trait(Cunning)}
        ~ Introspection += 1
        ~ Perception += 1
        ~ player_title = "Mercenary"
        -> choose_background
    + [(BACK)]
    // Reset all stats
    ~ Skills = ()
    ~ Traits = ()
    ~ player_class = ""
    ~ Strength = 1
    ~ Stealth = 1
    ~ Influence = 1
    ~ Empathy = 1
    ~ Logic = 1
    ~ Willpower = 1
    ~ Introspection = 1
    ~ Perception = 1
    ~ History = 1
        -> choose_class

=== alchemist_choose_traits ===
    ~ player_class = "Alchemist"
    {add_skill(Alchemy)}
    {add_skill(Writing)}
    {add_skill(Reading)}
    {add_trait(Outcast)}
    
    // Physical stats
    ~ Strength = 1
    ~ Stealth = 2
    
    // Mental stats
    ~ Influence = 1
    ~ Empathy = 3
    ~ Logic = 3
    ~ Willpower = 2
    ~ Introspection = 2
    
    // Passive stats
    ~ Perception = 2
    ~ History = 3
    
    What do you hope to find in alchemy?
    + [I want to become a merchant. My brews are of the finest quality, and once I make enough connections in the merchant world, I'll finally sell them for what they're worth.]
    // + Trading, +2 Influence
        {add_skill(Trading)}
        {add_skill(Negotiation)}
        ~ Influence += 2
        ~ player_title = "Potion Seller"
        -> choose_background
    + [I'm a scholar. I find beauty in the brews I concoct and want to know everything there is to know about my field.]
    // + Cultures, History
        {add_skill(Cultures)}
        ~ History += 1
        ~ player_title = "Scholar"
        -> choose_background
    + [I'm an alchemist solely for survival. I'm not very quick or strong, but my knowledge of alchemy lets me live to see the next day.]
    // + Survivor, Negotation, Introspection
        {add_trait(Survivor)}
        {add_skill(Negotiation)}
        ~ Introspection += 1
        ~ player_title = "Survivor"
        -> choose_background
    + [(BACK)]
    ~ Skills = ()
    ~ Traits = ()
    ~ player_class = ""
    ~ Strength = 1
    ~ Stealth = 1
    ~ Influence = 1
    ~ Empathy = 1
    ~ Logic = 1
    ~ Willpower = 1
    ~ Introspection = 1
    ~ Perception = 1
    ~ History = 1
        -> choose_class

=== thief_choose_traits ===
    ~ player_class = "Thief"
    {add_skill(Stealth)}
    {add_skill(Theft)}
    {add_skill(Lying)}
    {add_skill(Lockpicking)}
    
    // Physical stats
    ~ Strength = 1
    ~ Stealth = 1
    
    // Mental stats
    ~ Influence = 1
    ~ Empathy = 1
    ~ Logic = 1
    ~ Willpower = 1
    ~ Introspection = 1
    
    // Passive stats
    ~ Perception = 1
    ~ History = 1
    
    What drove you to this life?
    + [I'll do anything it takes to survive. Morality is a luxury only few can have. What matters most to me is that I make it to the next day.]
        {add_trait(Survivor)}
        ~ player_title = "Survivor"
        -> choose_background
    + [I'm a kleptomaniac. I love having things, especially *shiny* things, and I just can't seem to keep my hands to myself.]
        {add_trait(Kleptomaniac)}
        {add_trait(Immoral)}
        ~ player_title = "Kleptomaniac"
        -> choose_background
    + [I love chaos. I want to see the world burn and I'll go out of my way to rattle the cage.]
        {add_trait(Chaotic)}
        ~ player_title = "Agent of Chaos"
        -> choose_background
    + [I hate the rich. So long as I exist, so too will class disparity, and the only way to rise above your station is to take every advantage you can.]
        {add_trait(Moral)}
        ~ player_title = "\"Activist\""
        -> choose_background
    + [(BACK)]
    ~ Skills = ()
    ~ Traits = ()
    ~ player_class = ""
    ~ Strength = 1
    ~ Stealth = 1
    ~ Influence = 1
    ~ Empathy = 1
    ~ Logic = 1
    ~ Willpower = 1
    ~ Introspection = 1
    ~ Perception = 1
    ~ History = 1
        -> choose_class
-> DONE

=== choose_background ===
-> DONE
