![poorcpu](https://github.com/4techguns/CoreTemp/assets/42378704/48316fce-149e-4af6-8c94-162404a143e0)
# CoreTemp

(Not to be confused with [the other CoreTemp](https://www.alcpu.com/CoreTemp/))

A piece of software that just measures your CPU temperature. Used to be a project only for me, but is now released to the public

![A screenshot of CoreTemp](https://github.com/4techguns/CoreTemp/assets/42378704/e264571b-e08e-41c8-8ecb-5b7f6d7f6577)

Reminder: This is unfinished software. Expect less-than-normal behaviour.

## FAQ

### Q: What does CoreTemp provide?
CoreTemp provides a tray icon, a neat graph that shows the temperature over time, and warning/critical notifications

### Q: What CPUs are supported?
Most x86-based processors (possibly ARM processors, untested) *should* be supported. This program was only tested on a small range of AMD and Intel processors, so compatibility isn't always guaranteed

### Q: Can I disable the high temperature notifications/tray icon?
Yes. These have been disabled by default and can now be toggled as of 2.0

### Q: Your code sucks
I know. ~~Wait that's not even a question~~

### Q: Please update this I will sell you my kidney to get you to make one
Maybe, if I feel like it

### Q: This crashes on my machine
~~#RipBozo~~ 

Jk just make an issue and I'll hopefully try to fix it

If the message is "Nullable object must have a value", make sure you run the app with administrator permissions.

## Stolen homework aka credits
- [LibreHardwareMonitor library](https://github.com/LibreHardwareMonitor/LibreHardwareMonitor)
- [.NET 6 port of the data visualisation library from .NET Framework](https://www.nuget.org/packages/WinForms.DataVisualization)
- Parts of the Silk icon set (I believe the link to the original set is dead and I don't wanna be sued so I'm crediting them regardless)
- My motivation to even write a README in the first place
