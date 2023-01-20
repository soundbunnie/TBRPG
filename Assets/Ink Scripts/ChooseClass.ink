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
    {add_skill(Strength)}
    {add_skill(Force)}
    {add_skill(Lifting)}
    {add_skill(Running)}
    {add_skill(Intimidation)}
    What do you fight for?
    + [I fight for myself. The thrill of an honourable fight keeps me sane.]
        -> next_scene_placeholder
        {add_trait(Honourable)}
    + [I fight for power and status. Being able to step on the backs of others to get to the top means that I was stronger.]
        -> next_scene_placeholder
        {add_trait(Immoral)}
    + [I fight to survive. Picking locks is a waste of time when I can just break down the door.]
        -> next_scene_placeholder
        {add_trait(Survivor)}
    + [I fight to protect those who cannot defend themselves. Making somebodys life a little bit better makes me feel like I've earned my place in this world.]
        -> next_scene_placeholder
        {add_trait(Moral)}
        {add_trait(Generous)}
    + [I'm a mercenary. I know how to handle myself and I'm well paid, so long as I survive to the next day.]
        -> next_scene_placeholder
        {add_skill(Negotiation)}
        {add_trait(Cunning)}
    + [(BACK)]
    ~ Skills = ()
        -> choose_class

=== alchemist_choose_traits ===
    ~ player_class = "Alchemist"
    {add_skill(Alchemy)}
    {add_skill(Writing)}
    {add_skill(Reading)}
    {add_skill(Knowledge)}
    {add_trait(Outcast)}
    What do you hope to find in alchemy?
    + [I want to become a merchant. My brews are of the finest quality, and once I make enough connections in the merchant world, I'll finally sell them for what they're worth.]
        -> next_scene_placeholder
        {add_skill(Trading)}
    + [I'm a scholar. I find beauty in the brews I concoct and want to know everything there is to know about my field.]
        -> next_scene_placeholder
        {add_skill(Cultures)}
    + [I'm an alchemist solely for survival. I'm not very quick or strong, but my knowledge of alchemy lets me live to see the next day.]
        -> next_scene_placeholder
        {add_skill(Survivor)}
        {add_skill(Negotiation)}
    + [(BACK)]
        -> choose_class

=== thief_choose_traits ===
    ~ player_class = "Thief"
    What drove you to this life?
    + [I'll do anything it takes to survive. Morality is a luxury only few can have. What matters most to me is that I make it to the next day.]
        -> next_scene_placeholder
    + [I'm a kleptomaniac. I love having things, especially *shiny* things, and I just can't seem to keep my hands to myself.]
        -> next_scene_placeholder
    + [I love chaos. I want to see the world burn and I'll go out of my way to rattle the cage.]
        -> next_scene_placeholder
    + [I hate the rich. So long as I exist, so too will class disparity, and the only way to rise above your station is to take every advantage you can.]
        -> next_scene_placeholder
    + [(BACK)]
        -> choose_class
-> DONE

=== next_scene_placeholder ===
-> DONE