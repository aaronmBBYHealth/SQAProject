package greatcalltestautomation;

import com.intuit.karate.junit5.Karate;

public class GreatCallTest {
    @Karate.Test
    Karate testAll() {
        return Karate.run().relativeTo(getClass());
    }

}
