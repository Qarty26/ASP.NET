import { fr } from '@formkit/i18n'
import { defaultConfig } from '@formkit/vue'
import { rootClasses } from './formkit.theme'
import { genesisIcons } from '@formkit/icons'

export default defaultConfig({
    locale: 'en',
    config: {
        rootClasses,
        icons: {
            ...genesisIcons
        }
    }
})