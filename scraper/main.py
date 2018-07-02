from IgnScraper import IgnScraper

import json

class FinalJSON:
    def __init__(self):
        self.games = []
        self.emptyFields = []
        self.failedURLs = []
    
    def add(self, scraper):
        self.games = scraper.games
        self.emptyFields = scraper.emptyFields
        self.failedURLs = scraper.failedURLs

platforms = [
    'ps4', 'xbox-one', 'ps3', 'pc',
    'xbox-360', 'wii', 'wii-u', '3ds',
    'new-nintendo-3ds', 'nds', 'nintendo-switch',
    'vita', 'psp', 'iphone', 'ipad', 'xbox', 'gb', 'gba',
    'n64', 'mac', 'gcn', 'dc', 'ps', 'ps2', 'nng'
]

#initialize json formatting object
fJson = FinalJSON()

# #Use this to get all the games!
# for platform in platforms:
#     scraper = IgnScraper(platform, fJson.games)
#     scraper.run()
#     fJson.add(scraper)

#Use this to just get ps4 games
scraper = IgnScraper('ps4')
scraper.run()
fJson.add(scraper)

with open('games.json', 'w') as outfile:
    json.dump(fJson.__dict__, outfile)

    

