# CTM's Advancements Tracker

![](preview.gif)
###### Lightweight Tracker Tool for Minecraft All Advancements Speedrunners

## Purpose

This tool was originally designed for runner [Elysaku](https://www.twitch.tv/elysaku) and was used during his run that took the world record for All Advancements **(13:03:03)** from previous record holder Illumina **(14:52:46)**. The Advancements Tracker helps to alleviate many of the issues that come with a 12+ hour speedrun. Some advancements contain many small sub-criteria that must all be completed to earn the advancement. One example is *Adventuring Time*, which requires you to visit 42 different biomes. Keeping track of details like this is extremely cumbersome, especially over the course of multiple attemps. Removing the need to manually write these details down saves runners time, sanity, and paper, as well as making the category more accessible in general.

## How It Works

The tracker refreshes every time Minecraft saves. This is when it autosaves ever 5 minutes, but can be manually triggered by simply pausing and unpausing the game. (Think of Escape like a split key for the tracker). When Minecraft saves it writes to a JSON file with all of your completed advancements and partial completion criteria. This program reads that file at configurable intervals. The only privilege given to the tracker is `FileAccess.Read`, so there should be no possibility of file corruption. Also, `FileShare.ReadWrite` is used while parsing the file so as not to inturrupt Minecraft if it happens to save during a refresh.

## Speedrun.com Rules

This tool was designed from the beginning to strictly adhere to the category rules and requirements. As stated on the tracker itself, this program is in accordance with the Speedrun.com Minecraft: Java Edition ruleset as of its public release on 11/20/2020. The guidlines state that you are allowed to read from the advancements and statistics files during a run. All this program does is read from the advancements file of the most recently accessed save. No data is written anywhere, and absolutely nothing is read from the game's memory. That being said, if the mods have any questions I am more than happy to answer!

## Installation

If you're thinking about taking on the All Advancements category and would like to take advantage of this tool, simply download and extract the zip file from the [Releases](https://github.com/DarwinBaker/AdvancementsTracker/releases) page for your version of Minecraft. 
It's a standalone executable, so just run the exe inside and you're all set, no installation required!  

By default the program will look in your `AppData\Roaming\.minecraft\saves` folder, but if you're using a custom launcher or have moved your save directory, custom save paths are supported. This software is provided "as is", without warranty of any kind. 

You will likely run into Windows SmartScreen saying "Windows protected your PC" when you first run the program. You can safely ignore it and click "Run Anyway" and it shouldn't ask again. DO NOT download/run any version of this software not downloaded directly from this repository to avoid malware. I am not responsible if you run something that looks like this that didn't come from here.

#### Find Me At:
- [Twitch](https://www.twitch.tv/ctm_256)
- [YouTube](https://www.youtube.com/channel/UCdJ1FnTvTpna4VGkEyJ9_NA)
- [Reddit](https://www.reddit.com/user/_CTM_)
- [Speedrun.com](https://www.speedrun.com/user/CTM)

###### [Creating this tool took many hours and many energy drinks. If you find it helpful or enjoy watching someone else who does and you want to show your support, consider Donating! This program is and always will be completely free for everyone's use. :)](https://www.paypal.com/donate?hosted_button_id=EN29468P8CY24)
