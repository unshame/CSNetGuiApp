import imdb, urllib.request, io, json
access = imdb.IMDb()

top250 = access.get_bottom100_movies()
moviesIDs = []

for movie in top250:
    moviesIDs.append(movie.getID())

def getNames(persons, num, joiner=', ',):
    nl = []
    for i in range(0, min(num, len(persons))):
        person = persons[i]
        n = person.get('name', '')
        nl.append(n)
        
    return joiner.join(nl)

infos = []
i = 0
for id in moviesIDs:
    movie = access.get_movie(id)
    plot = movie.get('plot summary')
    plot = plot and plot[0]
    if not plot: 
        print('%s has no plot' % movie.get('title'))
        continue
    end = plot.find('::')
    if end != -1:
        plot = plot[:end]

    genre = movie.get('genres')
    if not genre or not genre[0]:
        print('%s has no genre' % movie.get('title'))
        continue
        
    runtime = movie.get('runtime')
    if not runtime or not runtime[0]:
        print('%s has no runtime' % movie.get('title'))
        continue
    info = {
        'title' : movie.get('title'),
        'year' : int(movie.get('year')),
        'genre' : movie.get('genres')[0],
        'runtime' : int(runtime[0]),
        'director' : getNames(movie.get('director'), 1),
        'stars' : getNames(movie.get('cast'), 3),
        'poster_url' : movie.get("cover url"),
        'plot' : plot,
    }
    infos.append(info)
    print('%s = %s' % (i, json.dumps(info, sort_keys=True, indent=4)))
    i += 1

file = open("movies.json", 'w')
file.write(json.dumps({ 'data' : infos}, sort_keys=True, indent=4))
file.close()