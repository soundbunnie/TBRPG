-> forest_rathunt_scene
=== forest_rathunt_scene ===
The forest is quiet. The dewey blades of grass dance to a silent tune, interrupted only by brief gusts of wind that flow around the trees. Aside from occassional chirps or footsteps made by nearby animals, the only sounds you hear are made by you.<br><br>Rays of light shine through the enormous trees that surround you, giving everything you see a sense of purity. Though you can't see much more than trees, shrubs and plants, all of the colours around you display such intensity, from the green shrubs to the bark of the trees - even the soil you walk upon seems vivid and rich. When you tilt your head upwards, you see fragments of the clear, blue sky through the thick leaves and manage to catch a few glimpses of some clouds passing by. #playMusic: mus_town
    * [There's something about this forest that is unsettling to me. I feel unsafe here.]-> forest_unsettling
    * [I take in the beauty all around me. It's peaceful.]->forest_beautiful
    * [This forest evokes no distinguishable feelings within me.]->forest_contd
= forest_unsettling
There isn't much to look at, and your eyes seem to have picked out a single object to stare at - the tree closest to the trap. You've stared at it for so long that the lines of the bark have begun to form faces. You know it's mind playing tricks on you, but this only serves to worsen your discomfort.->forest_contd
= forest_beautiful
You feel relaxed. Even though there are only a few sights and sounds, you feel as though you could stay here for hours.->forest_contd
    
= forest_contd
<br><br>Healthy green bushes and shrubbery surround you, making you fairly difficult to spot. You've been sitting here for what feels like ages, staring at a large hole in the ground, waiting patiently for your prey to emerge from its den.<br><br>You are hunting a pesky creature known as a Scavenger Rat. Though you've never encountered one yourself, Adela, an experienced hunter from your town, gave you some helpful information that you recorded in your Codex.
    * [I'll go in there and devise a plan once I know what their den is like.]
        -> into_rat_lair
    * [I'll stay out here. I don't want to be in their territory in case things don't go smoothly.]
        -> stay_in_forest
    

=== into_rat_lair ===
-> encounterFrog

=== stay_in_forest ===
-> encounterFrog
