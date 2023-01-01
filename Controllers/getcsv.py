import csv
import os
import sys
import re

import spotipy
# from dotenv import load_dotenv #for some reason cant get this module
from spotipy.oauth2 import SpotifyClientCredentials

# load credentials from .env file
# load_dotenv()
"""
CLIENT_ID = os.getenv("CLIENT_ID", "")
CLIENT_SECRET = os.getenv("CLIENT_SECRET", "")
OUTPUT_FILE_NAME = "track_info.csv"
"""
# again, the env file doesnt work, my solution:
CLIENT_ID = '82d3a91a6e86497da923d0cbc7e7950e'
CLIENT_SECRET = 'e7f19648a63a4cb7958c2f46df15d5c6'
OUTPUT_FILE_NAME = "testfunctionality.csv"
IMG_FILE_NAME = "imgUrl.csv"

# change for your target playlist
#PLAYLIST_LINK = "https://open.spotify.com/playlist/37i9dQZF1DX6IdqACeHRY7"

# authenticate
client_credentials_manager = SpotifyClientCredentials(
    client_id=CLIENT_ID, client_secret=CLIENT_SECRET
)

# create spotify session object
session = spotipy.Spotify(
    client_credentials_manager=client_credentials_manager)

# get uri from https link
"""if match := re.match(r"https://open.spotify.com/playlist/(.*)\?", PLAYLIST_LINK):
    playlist_uri = match.groups()[0]
else:
    raise ValueError("Expected format: https://open.spotify.com/playlist/...")
"""
# manually cuz this shit dont work
playlist_uri = sys.argv[1]

# get list of tracks in a given playlist (note: max playlist length 100)
tracks = session.playlist_tracks(playlist_uri)["items"]
playlist = session.playlist_cover_image(playlist_uri)
print(playlist)
# print(type(tracks))

"""#original from web
# create csv file
with open(OUTPUT_FILE_NAME, "w", encoding="utf-8") as file:
    writer = csv.writer(file)
    
    # write header column names
    writer.writerow(["track", "artist"])

    # extract name and artist
    for track in tracks:
        name = track["track"]["name"]
        artists = ", ".join(
            [artist["name"] for artist in track["track"]["artists"]]
        )

        # write to csv
        writer.writerow([name, artists])
"""
with open(IMG_FILE_NAME, "w", encoding="utf-8") as file:  # w rewrite, a append
    writer = csv.writer(file)
    # extract name and artist
    for track in tracks:
        playlistCover = playlist[0]["url"]
        writer.writerow([playlistCover])

# print(type(session.audio_features(id)))

# create csv file
with open(OUTPUT_FILE_NAME, "w", encoding="utf-8") as file:  # w rewrite, a append
    writer = csv.writer(file)

    # write header column names
    writer.writerow(["track", "id", "danceability", "energy", "key", "loudness",
                    "speechiness", "acousticness", "instrumentalness", "liveness", "valence", "tempo", "imageUrl"])

    # extract name and artist
    for track in tracks:
        # print(track)
        name = track["track"]["name"]
        id = track["track"]["id"]
        features = session.audio_features(id)
        danceability = features[0]["danceability"]
        energy = features[0]["energy"]
        key = features[0]["key"]
        loudness = features[0]["loudness"]
        speechiness = features[0]["speechiness"]
        acousticness = features[0]["acousticness"]
        instrumentalness = features[0]["instrumentalness"]
        livenesss = features[0]["liveness"]
        valence = features[0]["valence"]
        tempo = features[0]["tempo"]
        playlistCover = playlist[0]["url"]
        # print(features)
        # artists = ", ".join(
        #[artist["name"] for artist in track["track"]["artists"]]
        # )

        # write to csv
        writer.writerow([name, id, danceability, energy, key, loudness, speechiness,
                        acousticness, instrumentalness, livenesss, valence, tempo, playlistCover])

# print(type(session.audio_features(id)))
