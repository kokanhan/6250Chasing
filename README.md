# 6250Chasing
A small horror chasing game with core game mechanics implemented. 



> Written with [StackEdit](https://stackedit.io/).
## Some notes of this chasing pattern project

> If you bake the NavMesh and see your object with the baked NavMesh is floating(Y value is higher than what you expect)
> <br> Here is the solution<br> 
> https://answers.unity.com/questions/439309/dynamically-fixing-navmeshagent-base-offset.html<br>
> https://docs.unity3d.com/Manual/nav-HeightMesh.html 

Do remember to set your map objects to static before you bake them.  For now, I have not thought about the solution of locking rotation of the AI object yet. (Make it face to player)

> A quick review of **how to fetch objects in script:** www.youtube.com/watch?v=LXX_p33C0NM

>**This post save my life!** 
>https://answers.unity.com/questions/1264278/unity-5-directional-light-problem-please-help.html
> 
> When you select a scene, Unity will automatically bake all the lights
> and render things. BUT when you open a scene while playing the game in
> the editor, Unity will NOT bake the lights,render them, fix the
> effects and all, and this causes everything to stay dark.
> 
> You have to go to Window -> Lighting. In that Window, look for the
> "Debug Settings". Untick the "Auto Generate" checkbox and hit the
> "Generate Lighting" button beside it.


><br>
Understanding OnTrigger methods in Unity Why and when for OnTriggerEnter(), OnTriggerStay() and OnTriggerExit()
> https://www.patrykgalach.com/2019/09/05/understanding-ontrigger-methods/ 
> 
> <br><br>
> So sad that Unity still doesn't allow us to use **multithreading** .
> In Unity, a coroutine is a method that can pause execution and return
> control to Unity but then continue where it left off on the following
> frame. I use coroutine for openning door to make sure the door will be opened last for a while. 
