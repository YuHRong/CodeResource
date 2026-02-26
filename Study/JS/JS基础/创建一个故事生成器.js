// 1. 你应使用 let  声明以下变量： • adjective  • noun  • verb  • place  • adjective2  • noun2
let adjective, noun, verb, place, adjective2, noun2;
// 2. 你应该将上述变量赋值为你所选择的字符串值。
adjective = "fierce";
noun = "dragon";
verb = "roared";
place = "mountain cave";
adjective2 = "golden";
noun2 = "treasure";

// 3. 你应该声明一个 firstStory  变量。
let firstStory;

// 4. 你应使用以下故事模板创建第一个故事，并将其分配给 firstStory  变量："Once upon a time, there was a(n) [adjective] [noun] who loved to eat [noun2]. The [noun] lived in a [place] and had [adjective2] nostrils that blew fire when it was [verb]." ；
 firstStory = "Once upon a time, there was a(n) [adjective] [noun] who loved to eat [noun2]. The [noun] lived in a [place] and had [adjective2] nostrils that blew fire when it was [verb]."

 // 5. 你应该将第一个故事输出到控制台，使用的信息是 "First story: [firstStory]" 。
 console.log("First story: " + firstStory);

 // 6. 你应该为 adjective 、noun 、verb 、place 、adjective2  和 noun2  变量重新赋值。
    adjective = "fierce";
    noun = "dragon";
    verb = "roared";
    place = "mountain cave";
    adjective2 = "golden";
    noun2 = "treasure";

    // 7. 你应该声明一个 secondStory  变量。
    let secondStory;

    // 8. 你应使用以下故事模板创建第二个故事，并将其分配给 secondStory  变量："In a [place], a [adjective] [noun] [verb] loudly, scaring away all the villagers. The [adjective2] [noun2] was left unguarded." ；
    secondStory = "In a " + place + ", a " + adjective + " " + noun + " " + verb + " loudly, scaring away all the villagers. The " + adjective2 + " " + noun2 + " was left unguarded.";

    // 9. 你应该将第二个故事输出到控制台，使用的信息是 "Second story: [secondStory]" 。
    console.log("Second story: " + secondStory);