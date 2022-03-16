# app-ephemeraltest

vcluster:
  image: rancher/k3s:v1.19.5-k3s2    
  extraArgs:
    - --service-cidr=10.96.0.0/12    


 persistentvolumeclaims:
    enabled: false
    
