# ARnival Map

Augmented Reality map for cruises.

[MangoHacks 2018 submission.](https://devpost.com/software/arnival-map)

[Video demo here](https://youtu.be/DuWBomCgM4U)

## What it does

Scan a tracker in the app and it will pop up with a 3D interactive map of a cruise ship, with an indicator for your "current location".

## How I built it

I used Unity3D with Vuforia to develop the app, and I created the models used in SketchUp.

## Challenges I ran into

Since I did not have access to a printer during the hackathon, I had to display the tracker on my laptop, which resulted in some unsteadiness in the tracking. Additionally, I had to model the cruise ship map myself, which was difficult since I do not have much experience in designing 3d models. Lastly, I learned that Vuforia has issues with the new Unity3d UI system, so I had to revert to using the legacy GUI.

## Accomplishments that I'm proud of

I'm proud of the animations that trigger when the user switches - having the floors slide out when active and turn transparent when inactive makes it much easier to see the currently selected floor.

## What I learned

I learned a lot about Vuforia and using it with Unity3d.

## What's next for ARnival Map

I think it would be great to redesign the app to have a much more professional feel - higher quality models and animations, better UI design, even an app icon. I think that it would also be a cool idea to implement different types of trackers, rather than just for maps, and have them scattered around a cruise ship to give different information and provide entertainment for the guests on the cruise.

