import urllib.request as r
r.install_opener(r.build_opener(r.ProxyHandler({'http': r'http://username:password@proxy.det.nsw.edu.au:8080'}), r.HTTPBasicAuthHandler(), r.HTTPHandler))