## Τίτλος

Klima:
    Επαυξημένη ευαισθητοποίηση σε πραγματικό χρόνο για έναν καλύτερο πλανήτη

## Τι είναι το Klima

Το Klima είναι μια εφαρμογή επαυξημένης πραγματικότητας (AR) που έχει σκοπό να ευαισθητοποιήσει τον χρήστη σε θέματα κλιματικής αλλαγής. Xρησιμοποιεί την κάμερα του κινητού για να σκανάρει το περιβάλλον και να εντοπίσει αντικείμενα που συμβάλουν στις εκπομπές αερίων του θερμοκηπίου και τότε παρέχει πληροφορίες που μπορούν να μειώσουν αυτές τις εκπομπές. Με την αναγνώριση εικόνας σε πραγματικό χρόνο και την ανάλυση περιβαλλοντικών επιπτώσεων, οι χρήστες λαμβάνουν συμβουλές και καθοδήγηση για να μειώσουν το αποτύπωμά του CO2 τους.

# Πώς λειτουργεί

Η χρήση της εφαρμογής μας έχει τα ακόλουθα βήματα:

Αρχικά προϋποθέτει είσοδο στο σύστημα ώστε να διατηρηθούν τα στοιχεία του χρήστη σε μία πλατφόρμα που θα δημιουργήσουμε μελλοντικά.

Στις βασικές επιλογές του menu, ο χρήστης έχει την δυνατότητα να συμμετάσχει σε ένα ενημερωτικό Quiz εντός της εφαρμογής για να βελτιώσει τις γνώσεις και την κατανόησή του για τις περιβαλλοντικές επιπτώσεις των καθημερινών αντικειμένων, δίνοντάς τη δυνατότητα να κάνει συνειδητές επιλογές για ένα βιώσιμο μέλλον.

Η βασική επιλογή της εφαρμογής είναι το AR Walkthrough. Με αυτή την επιλογή η κάμερα του κινητού ενεργοποιείται και ο χρήστης καλείται να στρέψει το smartphone του προς τα αντικείμενα που θέλει να ανιχνεύσει, όπως τηλεόραση, ψυγείο κλπ. Η εφαρμογή θα εντοπίσει μόνο αντικείμενα που συμβάλλουν στo φαινόμενο του θερμοκηπίου:

Όταν η εφαρμογή εντοπίσει ένα αντικείμενο, εμφανίζεται μια ειδοποίηση, η οποία εμφανίζει με animation το ποσοστό των εκπομπών CO2 που συνεισφέρει το στοχευμένο αντικείμενο σε σύγκριση με άλλα αντικείμενα καθημερινής χρήσης. Επιπλέον, μια επιπλέον ποσοστιαία ένδειξη παρουσιάζει τις ετήσιες εκπομπές που παράγονται από το αντικείμενο, διευκρινίζοντας στους χρήστες τις επιπτώσεις του στο περιβάλλον.

Πατώντας το κουμπί “Περισσότερα”, εμφανίζεται μια λεπτομερής σελίδα που δείχνει τις εκπομπές του αντικειμένου. Η σελίδα αποκαλύπτει την ετήσια παραγωγή CO2 σε τόνους, παρέχοντας μια σαφή κατανόηση των περιβαλλοντικών επιπτώσεών της. Επιπλέον, οι χρήστες μπορούν να ανακαλύψουν ένα fun fact που αναδεικνύει καλύτερα την κλίμακα των εκπομπών του αντικειμένου. Τέλος, η σελίδα παρουσιάζει συγκριτικά στατιστικά στοιχεία, συγκρίνοντας τις εκπομπές CO2 του αντικειμένου σε διαφορετικές χώρες, προσφέροντας πολύτιμες πληροφορίες για τις παγκόσμιες παραλλαγές.

# Unity

EditorVersion: 2022.2.5f1

# OpenCV for Unity

Το ακόλουθο OpenCV package χρησιμοποιήθηκε για object detection:

    OpenCV v.2.4.7
    ίδιο API με το OpenCV Java 4.5.5
    Build Android : API level 24 ή μεταγενεστερο

# YOLOv4 model

Για να χρησιμοποιήσουμε το μοντέλο YOLOv4 με OpenCV, χρειαστήκαμε τα ακόλουθα αρχεία:

1. Το αρχείο διαμόρφωσης YOLOv4: Αυτό το αρχείο περιέχει την αρχιτεκτονική δικτύου, συμπεριλαμβανομένου του αριθμού των επιπέδων, των φίλτρων και των κλάσεων που χρησιμοποιούνται για την ανίχνευση αντικειμένων. Το αρχείο ονομάζεται "yolov4.cfg".

2. Το αρχείο "βαρών" YOLOv4: Αυτό το αρχείο περιέχει τις παραμέτρους του δικτύου. Το αρχείο ονομάζεται "yolov4.weights".

3. Το αρχείο κλάσεων YOLOv4: Αυτό το αρχείο περιέχει τα ονόματα των κλάσεων που το μοντέλο εκπαιδεύτηκε να ανιχνεύει. Το αρχείο συνήθως ονομάζεται "coco.names" για το τυπικό μοντέλο YOLOv4, το οποίο εκπαιδεύτηκει στο σύνολο δεδομένων Common Objects in Context (COCO).

## Συμμετέχοντες

Project/Oμάδα:
    Klima by AR Hawks

Μαθητές:
    Δημήτρης Συκάς (Α Λυκείου)
    Παναγιώτης Τσότρος (Α Λυκείου)

Εκπαιδευτικός:
    Γρηγόρης Συκάς (Καθηγητής Φυσικής, 1ο ΓΕΛ Ελευσίνας)
