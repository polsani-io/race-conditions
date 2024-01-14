(ns race-condition.core
  (:gen-class))

(def value (atom 0))

(defn new-calculated-value
  [calculated-value]
  (inc calculated-value))

(defn update-value-with-swap!
  []
  (swap! value new-calculated-value))

(defn create-future-vector
  []
  (vec (for [_ (range 10000)]
         (future
           (update-value-with-swap!)))))

(def my-future-vector (create-future-vector))

(defn main
  []
  (println "Starting the program...")
  (doseq [future my-future-vector]
    (deref future))
  (println (str "The final value is: " @value)))

(main)
