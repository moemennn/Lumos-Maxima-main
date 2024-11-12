# Lumos-Maxima

A group project done for the Nasa Space Apps 2021 challenge, I intend to create a tool that allows users to visualize light curves of asteroids using unity engine, MatLab Plot library and alot of coding!

The amount of light emitted by Asteroids is insufficient to allow us to see their shapes. However, one of the few clues through which we can understand their shapes is their light curves. in the Light of this, an effective, practical, and simple-to-use tool to explore how an asteroid's shape affects its light curve has been developed. previous systems are extremely complex, and their user interfaces are extremely difficult to use. As a result, we created the ideal tool for understanding the light curves of asteroids and unraveling the mysteries of the Trojan asteroids in order to help researchers learn more about the origins of our solar system.

The project is mainly built using the Unity engine, we begin by extracting an image of every frame, combining the grayscale pixel values then sending these values to a text file to be graphed in python using the mat plot library. However, this solution proved too slow and the curve did not update in time resulting in a jagged line graph. We then opted to take these values and use them as position coordinates for an empty object with a trail component. This object is then visible to a separate graph camera that finally takes it and projects it into a render texture.

We use a simple implementation of the inverse square law for the deformation mechanism. Each vertex is given a velocity in its normal direction then the vertex starts being displaced until the damping reaches a maximum.
