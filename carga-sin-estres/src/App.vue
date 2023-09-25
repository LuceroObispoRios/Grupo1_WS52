<script>
import FooterContent from "@/public/pages/footer-content.component.vue";
export default {
  name: "app",
  components: {FooterContent}
}
</script>

<template>
  <div>
    <router-view></router-view>
    <footer-content></footer-content>
  </div>
</template>



<style scoped>
</style>
