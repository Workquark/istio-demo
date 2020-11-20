## Istio implementation

- Install istio operator - `istioctl operator init` . This installs operator in `istio-operator` namespace
- Install istio operator components - 
  - Create istio namespace - `kubectl create namespace istio-system`
  - Apply the configuration - `kubectl apply -f istio-operator.yaml`
  - Below configuration is for google cloud. 
  - Load Balancer IP  is the static ip created on cloud console. 
  - Create Istio app gateway - `kubectl apply -f app-gateway.yaml`
  - Create destination rules - `kubectl apply -f virtual-service-all-v1.yaml`
  - 

####  **Below is the sample of istio operator config **
```apiVersion: install.istio.io/v1alpha1
kind: IstioOperator
metadata:
  namespace: istio-system
  name: app-istiocontrolplane
spec:
  profile: default
  components:
    ingressGateways:
      - name: istio-ingressgateway
        enabled: true
        k8s:
          serviceAnnotations:
            cloud.google.com/load-balancer-type: “internal”
          service:
            type: LoadBalancer
            loadBalancerIP: xxx.xxx.xxx.xxx
      # - namespace: user-ingressgateway-ns
      #   name: ilb-gateway
      #   enabled: true
      #   k8s:
      #     resources:
      #       requests:
      #         cpu: 200m
      #     serviceAnnotations:
      #       cloud.google.com/load-balancer-type: "internal"
      #     service:
      #       ports:
      #       - port: 8060
      #         targetPort: 8060
      #         name: tcp-citadel-grpc-tls
      #       - port: 5353
      #         name: tcp-dns
    pilot:
      k8s:
        resources:
          requests:
            memory: 3072Mi
    egressGateways:
    - name: istio-egressgateway
      enabled: true```
